
using AGC.Entity;
using AGC_CSWin;
using AGC4WApi;
using AgcCommBase;
using AutoGCLib;

using System;
using System.Windows.Forms;

namespace Agc_CsWin.frm.Test
{
    public partial class frm扩展对象列表 : Form
    {
        //private string mstrTypeParas = "";
        public frm扩展对象列表()
        {
            InitializeComponent();
            clsSysParaEN.strUserId = "pyf";
            clsPubVar.CurrSelPrjId = "0116";
        }

        private void btnBindExObjLst_Click(object sender, EventArgs e)
        {
             string strPrjId = "0116";
             clsFieldTabENEx objFieldTabENEx = clsFieldTabExWApi.GetObjExByFldName("UserId", strPrjId);
            MessageBox.Show(objFieldTabENEx.Caption);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //if (this.lvvViewInfo.SelectedItems.Count != 1)
        //    //{
        //    //    DialogResult result;
        //    //    result = MessageBox.Show("请选择一条记录！");
        //    //    return;
        //    //}

        //    //string strKeyId = this.lvvViewInfo.SelectedItems[0].Tag.ToString();
        //    string strViewId ="01160002";
        //    string strViewName = "wfmSex_QUDI";
        //    string strCondition = string.Format("ViewName='{0}' And PrjId='{1}'", strViewName, "0116");
        //    strViewId = clsViewInfoWApi.GetFirstID_S(strCondition);
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg.Text = "";
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebCtlViewCode;
        //    clsPubConst.LangType ltLangType = clsPubConst.LangType.CSharp;
        //    clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.DataBaseType.MsSql;

        //    try
        //    {

        //        string strCodeText = AutoGC.GeneCode(cnClassName, mstrTypeParas,
        //                       ltLangType, dbtDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0005", "01", clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlViewCode(strViewId, strNetVersion,
        //        //    clsPubVar.objCurrSelProjectEN,
        //        //      clsSysParaEN.strUserId,
        //        //     clsSysParaEN.strUserName,
        //        //     objUserCodePathEN.CodePath, "",
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        txtCode.Text = strCodeText;
        //        //txtCode.Text = strClsName;

        //        //txtCodePath.Text = strCodePath;
        //        //tabViewInfoListCode.SelectedIndex = 1;
        //    }
        //    catch (Exception objException)
        //    {
        //        lblMsg.Text = objException.Message;
        //        MessageBox.Show(objException.Message);
        //    }
        //    MessageBox.Show("生成《表控件View代码》完成！");

        //}

        //private void btnCtlControlCode_Web_Click(object sender, EventArgs e)
        //{
        //    string strViewId = "01160002";
        //    string strViewName = "wfmSex_QUDI";
        //    string strCondition = string.Format("ViewName='{0}' And PrjId='{1}'", strViewName, "0116");
        //    strViewId = clsViewInfoWApi.GetFirstID_S(strCondition);
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg.Text = "";
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebCtlControlCode;
        //    clsPubConst.LangType ltLangType = clsPubConst.LangType.CSharp;
        //    clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.DataBaseType.MsSql;

        //    try
        //    {

        //        string strCodeText = AutoGC.GeneCode(cnClassName, mstrTypeParas,
        //                       ltLangType, dbtDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0005", "01", clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneCtlControlCode(strViewId, strNetVersion,
        //        //    clsPubVar.objCurrSelProjectEN,
        //        //      clsSysParaEN.strUserId,
        //        //     clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        txtCode.Text = strCodeText;

        //    }
        //    catch (Exception objException)
        //    {
        //        lblMsg.Text = objException.Message;
        //        MessageBox.Show(objException.Message);
        //    }
        //    MessageBox.Show("生成《表控件Control代码》完成！");

        //}

        //private void btnGenViewCode_Web_Click(object sender, EventArgs e)
        //{
        //    string strViewId = "01160002";
        //    string strViewName = "wfmSex_QUDI";
        //    string strCondition = string.Format("ViewName='{0}' And PrjId='{1}'", strViewName, "0116");
        //    strViewId = clsViewInfoWApi.GetFirstID_S(strCondition);
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg.Text = "";
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewCode;
        //    clsPubConst.LangType ltLangType = clsPubConst.LangType.CSharp;
        //    clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.DataBaseType.MsSql;

        //    try
        //    {

        //        string strCodeText = AutoGC.GeneCode(cnClassName, mstrTypeParas,
        //                       ltLangType, dbtDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0004", "01", clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);

        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneViewCode(strViewId, strNetVersion,
        //        //    clsPubVar.objCurrSelProjectEN,
        //        //      clsSysParaEN.strUserId,
        //        //     clsSysParaEN.strUserName,
        //        //     objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        txtCode.Text = strCodeText;

        //    }
        //    catch (Exception objException)
        //    {
        //        lblMsg.Text = objException.Message;
        //        MessageBox.Show(objException.Message);
        //    }
        //    MessageBox.Show("生成《界面View代码》完成！");

        //}

        //private void btnGenControlCode_Web_Click(object sender, EventArgs e)
        //{
        //  string strViewId ="01160002";
        //    string strViewName = "wfmSex_QUDI";
        //    string strCondition = string.Format("ViewName='{0}' And PrjId='{1}'", strViewName, "0116");
        //    strViewId = clsViewInfoWApi.GetFirstID_S(strCondition);
        //    if (strViewId.Trim().Length == 0)
        //    {
        //        lblMsg.Text = "没有选择记录，请选择一个有效的界面记录!";
        //        return;
        //    }
        //    lblMsg.Text = "";
        //    string strTabId = "";
        //    string strRe_ClsName = "";
        //    string strRe_FileNameWithModuleName = "";
        //    clsPubConst.ClassName cnClassName = clsPubConst.ClassName.WebViewControlCode;
        //    clsPubConst.LangType ltLangType = clsPubConst.LangType.CSharp;
        //    clsPubConst.DataBaseType dbtDataBaseType = clsPubConst.DataBaseType.MsSql;

        //    try
        //    {

        //        string strCodeText = AutoGC.GeneCode(cnClassName, mstrTypeParas,
        //                       ltLangType, dbtDataBaseType, strTabId, strViewId, clsPubVar.CurrSelPrjId, clsPubVar.CurrPrjDataBaseId,
        //                       clsSysParaEN.strUserId, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

        //        clsUserCodePathEN objUserCodePathEN = clsUserCodePathExWApi.GetObjByCodeTypeIdCache("0004", "01", clsPubVar.CurrSelPrjId, clsSysParaEN.strUserId);
        //        //strCodeText = clsViewInfoBLEx_GeneCode.GeneControlCode(strViewId, strNetVersion,
        //        //    clsPubVar.objCurrSelProjectEN,
        //        //      clsSysParaEN.strUserId,
        //        //     clsSysParaEN.strUserName, objUserCodePathEN.CodePath, objUserCodePathEN.CodePathBackup,
        //        //   ref strFileName4GenCode, ref strClsName, ref strCodePath);
        //        txtCode.Text = strCodeText;

        //    }
        //    catch (Exception objException)
        //    {
        //        lblMsg.Text = objException.Message;
        //        MessageBox.Show(objException.Message);
        //    }
        //    MessageBox.Show("生成《界面View代码》完成！");

        //}


    }
}
