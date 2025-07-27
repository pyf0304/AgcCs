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
    public class clsAndroidGCTests
    {
        [TestMethod()]
        public void AndroidButton_GeneCodeTest()
        {
            StringBuilder sbCode = new StringBuilder();
            clsAndroidButtonENEx objAndroidButtonENEx = new clsAndroidButtonENEx();
            objAndroidButtonENEx.CtrlId = "btnAdd";
            objAndroidButtonENEx.OnClick = "btnAdd_Click";
            objAndroidButtonENEx.Text = "测试Add";
            objAndroidButtonENEx.layout_width = "wrap_content";
            objAndroidButtonENEx.layout_height = "wrap_content";
            objAndroidButtonENEx.mTextSize = "12sp";
            objAndroidButtonENEx.minHeight = "35dp";
            objAndroidButtonENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidButtonENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            clsAndroidButtonBLEx.GeneCode(objAndroidButtonENEx, sbCode);
            string ss = sbCode.ToString();

            //   Assert.Fail();
        }
        [TestMethod()]
        public void AndroidTextView_GeneCodeTest()
        {
            StringBuilder sbCode = new StringBuilder();
            clsAndroidTextViewENEx objAndroidTextViewENEx = new clsAndroidTextViewENEx();
            objAndroidTextViewENEx.CtrlId = "lblAdd";
            objAndroidTextViewENEx.OnClick = "btnAdd_Click";
            objAndroidTextViewENEx.Text = "测试Add";
            objAndroidTextViewENEx.layout_width = "wrap_content";
            objAndroidTextViewENEx.layout_height = "wrap_content";
            objAndroidTextViewENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidTextViewENEx.layout_constraintTop_toBottomOf = "@+id/lblNum2";
            clsAndroidTextViewBLEx.GeneCode(objAndroidTextViewENEx, sbCode);
            string ss = sbCode.ToString();

            //   Assert.Fail();
        }
        [TestMethod()]
        public void AndroidEditText_GeneCodeTest()
        {
            StringBuilder sbCode = new StringBuilder();
            clsAndroidEditTextENEx objAndroidEditTextENEx = new clsAndroidEditTextENEx();
            objAndroidEditTextENEx.CtrlId = "txtAdd";
            objAndroidEditTextENEx.OnClick = "btnAdd_Click";
            objAndroidEditTextENEx.Text = "测试Add";
            objAndroidEditTextENEx.layout_width = "wrap_content";
            objAndroidEditTextENEx.layout_height = "wrap_content";
            objAndroidEditTextENEx.layout_constraintStart_toStartOf = "parent";
            objAndroidEditTextENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            clsAndroidEditTextBLEx.GeneCode(objAndroidEditTextENEx, sbCode);
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