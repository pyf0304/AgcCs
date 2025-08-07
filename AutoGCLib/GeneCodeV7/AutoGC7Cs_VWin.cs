using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.file;
using com.taishsoft.util;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 
    /// </summary>
    class AutoGC7Cs_VWin : AutoGC_Cs_VWin_PubFun
    {
        private string strFolder;   //˽����ʱ����
                                    //		int intZIndex;		///�ؼ��������
                                    //		int intCurrLeft;   ///�ؼ�����߿�;
                                    //		int intCurrTop;   ///�ؼ��Ķ����;
                                    //bool objViewInfoENEx.IsUseCtl = true;

        //		private objViewInfoENEx.FileName;		//���ɵ��ļ�����
        #region ���캯��
        public AutoGC7Cs_VWin()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }

        public AutoGC7Cs_VWin(string strViewId) : base(strViewId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }
        #endregion


      
     

       

    
        /// <summary>
        /// ���ɲ�ѯɾ����������,�ڽ�����Ե������ڱ༭�Ľ���
        /// ע:��ʹ�ÿؼ�(NoCtrl)
        /// </summary>
        /// <returns></returns>
        public string A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral_Net2005_Design()
        {
            Point pntLocation = new Point();
            ArrayList arrInnerCtlSet = new ArrayList();		//�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;
            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///���༭����
            CheckEditRegion();
            //���LIstView����
            CheckListViewRegion();
            //����ѯ����
            CheckQueryRegion();
            //���Excel��������
            CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_LV";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_QD_LV.Designer.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objQryRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objQryRegionFldsEx.CtrlId4Win = objQryRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }
                //��һ��:���ɵ��������ռ�

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_QD_LV ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "partial class frm{0}_QD_LV", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //������:���ɿؼ����ڲ��ؼ�����������

                //���Ĳ�:���ɱ�������������
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// ����������������");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                //���岽:������������ʹ�õ���Դ
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// ������������ʹ�õ���Դ��");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components !=  null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //������:�����������ɵĴ���

                strCodeForCs.Append("\r\n" + "#region �����������ɵĴ���");
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// �����֧������ķ��� - ��Ҫʹ�ô���༭�� ");
                strCodeForCs.Append("\r\n /// �޸Ĵ˷��������ݡ�");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                        objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                        objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }

                strCodeForCs.Append("\r\n" + "this.btnQuery = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnUpdate = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnAdd = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnDelRec = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblRecNum = new System.Windows.Forms.Label();");

                strCodeForCs.AppendFormat("\r\n" + "this.lv{0} = new System.Windows.Forms.ListView();",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition = new System.Windows.Forms.GroupBox();");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.SuspendLayout();");

                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
                objBiDimDistribue.StartX = 10;
                objBiDimDistribue.StartY = 18;
                objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
                objBiDimDistribue.ColWidth = 250;
                objBiDimDistribue.LineHeight = 30;
                int intFieldIndex = 0;

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                // 
                                // checkBox1
                                // 
                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;

                            case "ComboBox":
                            case "DropDownList":

                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;",
                                     objQryRegionFldsEx.CtrlId4Win);

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;

                            default:

                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                                //end of switch
                        }
                        //end of if(objQryRegionFldsEx.IsIdentity  ==  false && objQryRegionFldsEx.IsCtlField  ==  true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objQryRegionFldsEx in arrViewCtlFldSet4Query)
                    intFieldIndex++;	//�ֶ������1
                }

                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Location = new System.Drawing.Point(192, 144);");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                    intIndex++);
                // 
                // btnAdd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnAdd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Location = new System.Drawing.Point(408, 137);");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Name = \"btnAdd\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnAdd.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnAdd.Text = \"���\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Click +=  new System.EventHandler(this.btnAdd_Click);");
                // 
                // 
                // btnUpdate
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnUpdate");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Location = new System.Drawing.Point(496, 137);");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Name = \"btnUpdate\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnUpdate.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Text = \"�޸�\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Click +=  new System.EventHandler(this.btnUpdate_Click);");
                // 
                // btnDelRec
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnDelRec");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Location = new System.Drawing.Point(576, 137);");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Name = \"btnDelRec\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnDelRec.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Text = \"ɾ����¼\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Click +=  new System.EventHandler(this.btnDelRec_Click);");
                // 
                // btnExportExcel4Dg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnExportExcel4Dg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 137);");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Name = \"btnExportExcel4Dg\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnExportExcel4Dg.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Text = \"����Excel\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Click +=  new System.EventHandler(this.btnExportExcel4Dg_Click);");
                //
                //��ѯ��ť<btnQuery>
                //
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnQuery");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Location = new System.Drawing.Point(328, 137);");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Name = \"btnQuery\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnQuery.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnQuery.Text = \"��ѯ\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Click +=  new System.EventHandler(this.btnQuery_Click);");
                // 
                // lblRecNum
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblRecNum");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Location = new System.Drawing.Point(752, 144);");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Name = \"lblRecNum\";");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Size = new System.Drawing.Size(112, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.TabIndex = {0} ;",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Text = \"��¼��:\";");


                // 
                // lv{0}
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// lv{0}",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Dock = System.Windows.Forms.DockStyle.Fill;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Location = new System.Drawing.Point(0, 176);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Name = \"lv{0}\";",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Size = new System.Drawing.Size(1000, 524);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.ColumnClick +=  new System.Windows.Forms.ColumnClickEventHandler(this.lv{0}_ColumnClick);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.TabIndex = {1};",
                    objViewInfoENEx.TabName_Out,
                    intIndex++);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.View = System.Windows.Forms.View.Details;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Click +=  new System.EventHandler(this.lv{0}_Click);",
                    objViewInfoENEx.TabName_Out);

                // 
                // gbQueryCondition
                // 
                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.Controls.Add({0});",
                        strCtlName);
                }
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnExportExcel4Dg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnQuery);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnUpdate);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnAdd);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnDelRec);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblMsg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblRecNum);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Name = \"gbQueryCondition\";");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Size = new System.Drawing.Size(720, 176);");
                strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.TabStop = false;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Text = \"��ѯ����\";");

                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                // 
                // frm{0}_QD_LV
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_QD_LV",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                //				strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.Append("\r\n" + "this.ClientSize = new System.Drawing.Size(1000, 700);");
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.lv{0});",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.gbQueryCondition);");
                strCodeForCs.Append("\r\n" + "this.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");

                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_QD_LV\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_QD_LV\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;");

                strCodeForCs.AppendFormat("\r\n" + "this.Load +=  new System.EventHandler(this.frm{0}_QD_Load);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //������:���ɿؼ����ڲ��ؼ�����������

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }


                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnQuery;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnUpdate;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnAdd;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnDelRec;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnExportExcel4Dg;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblRecNum;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.GroupBox gbQueryCondition;");

                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.ListView lv{0};",
                    objViewInfoENEx.TabName_Out);

                //���߲�:����this.load����

                //���һ��:������Ľ������������ռ�Ľ�����
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //������д���ļ���;
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();

        }

        /// <summary>
        /// ���ɲ�ѯɾ����������,�ڽ�����Ե������ڱ༭�Ľ���
        /// ע:��ʹ�ÿؼ�(NoCtrl)
        /// </summary>
        /// <returns></returns>
        public string A_GenQueryDelAffitUpdInsRecCodeWithDGV_NoContral_Net2005_Design()
        {
            Point pntLocation = new Point();
            ArrayList arrInnerCtlSet = new ArrayList();		//�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;
            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Query.FieldNum());
            ///���༭����
            CheckEditRegion();
            //���LIstView����
            CheckListViewRegion();
            //����ѯ����
            CheckQueryRegion();
            //���Excel��������
            CheckExcelExportRegion();
            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QD_DGV";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_QD_DGV.Designer.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objQryRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objQryRegionFldsEx.CtrlId4Win = objQryRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }
                //��һ��:���ɵ��������ռ�

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_QD_DGV ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "partial class frm{0}_QD_DGV", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //������:���ɿؼ����ڲ��ؼ�����������

                //���Ĳ�:���ɱ�������������
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// ����������������");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                //���岽:������������ʹ�õ���Դ
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// ������������ʹ�õ���Դ��");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components !=  null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //������:�����������ɵĴ���

                strCodeForCs.Append("\r\n" + "#region �����������ɵĴ���");
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// �����֧������ķ��� - ��Ҫʹ�ô���༭�� ");
                strCodeForCs.Append("\r\n /// �޸Ĵ˷��������ݡ�");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                        objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                        objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }

                strCodeForCs.Append("\r\n" + "this.btnQuery = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnUpdate = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnAdd = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnDelRec = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblRecNum = new System.Windows.Forms.Label();");

                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0} = new System.Windows.Forms.DataGridView();",
                    objViewInfoENEx.TabName_Out);

                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0} = new System.Windows.Forms.DataGridViewTextBoxColumn();",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition = new System.Windows.Forms.GroupBox();");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.SuspendLayout();");

                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
                objBiDimDistribue.StartX = 10;
                objBiDimDistribue.StartY = 18;
                objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
                objBiDimDistribue.ColWidth = 250;
                objBiDimDistribue.LineHeight = 30;
                int intFieldIndex = 0;

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                // 
                                // checkBox1
                                // 
                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                            case "ComboBox":
                            case "DropDownList":
                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;

                            default:

                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objQryRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                                //end of switch
                        }
                        //end of if(objQryRegionFldsEx.IsIdentity  ==  false && objQryRegionFldsEx.IsCtlField  ==  true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objQryRegionFldsEx in arrViewCtlFldSet4Query)
                    intFieldIndex++;	//�ֶ������1
                }

                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Location = new System.Drawing.Point(192, 144);");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                    intIndex++);
                // 
                // btnAdd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnAdd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Location = new System.Drawing.Point(408, 137);");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Name = \"btnAdd\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnAdd.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnAdd.Text = \"���\";");
                strCodeForCs.Append("\r\n" + "this.btnAdd.Click +=  new System.EventHandler(this.btnAdd_Click);");
                // 
                // 
                // btnUpdate
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnUpdate");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Location = new System.Drawing.Point(496, 137);");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Name = \"btnUpdate\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnUpdate.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Text = \"�޸�\";");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Click +=  new System.EventHandler(this.btnUpdate_Click);");
                // 
                // btnDelRec
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnDelRec");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Location = new System.Drawing.Point(576, 137);");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Name = \"btnDelRec\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnDelRec.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Text = \"ɾ����¼\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Click +=  new System.EventHandler(this.btnDelRec_Click);");
                // 
                // btnExportExcel4Dg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnExportExcel4Dg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Location = new System.Drawing.Point(664, 137);");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Name = \"btnExportExcel4Dg\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnExportExcel4Dg.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Text = \"����Excel\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Click +=  new System.EventHandler(this.btnExportExcel4Dg_Click);");
                //
                //��ѯ��ť<btnQuery>
                //
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnQuery");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Location = new System.Drawing.Point(328, 137);");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Name = \"btnQuery\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Size = new System.Drawing.Size(80, 26);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnQuery.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnQuery.Text = \"��ѯ\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Click +=  new System.EventHandler(this.btnQuery_Click);");
                // 
                // lblRecNum
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblRecNum");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Location = new System.Drawing.Point(752, 144);");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Name = \"lblRecNum\";");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Size = new System.Drawing.Size(112, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.TabIndex = {0} ;",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Text = \"��¼��:\";");


                // 
                // dgv{0}
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// dgv{0}",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] ",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                for (int i = 0; i < objViewInfoENEx.arrDGRegionFldSet.Count; i++)
                {
                    clsDGRegionFldsENEx ObjLstViewRegionFldsEx = objViewInfoENEx.arrDGRegionFldSet[i] as clsDGRegionFldsENEx;
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {
                        if (i + 1 == objViewInfoENEx.arrDGRegionFldSet.Count)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}",
                             ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "});");
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0},",
                                ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        }
                    }
                }


                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Dock = System.Windows.Forms.DockStyle.Fill;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Location = new System.Drawing.Point(0, 176);",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Name = \"dgv{0}\";",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Size = new System.Drawing.Size(1000, 524);",
                    objViewInfoENEx.TabName_Out);
                //strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.ColumnClick +=  new System.Windows.Forms.ColumnClickEventHandler(this.dgv{0}_ColumnClick);",
                //    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.TabIndex = {1};",
                    objViewInfoENEx.TabName_Out,
                    intIndex++);
                //strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.View = System.Windows.Forms.View.Details;",
                //    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.CellClick +=  new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv{0}_CellClick);",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.Click +=  new System.EventHandler(this.dgv{0}_Click);",
                    objViewInfoENEx.TabName_Out);

                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {

                        strCodeForCs.Append("\r\n" + "// ");
                        strCodeForCs.AppendFormat("\r\n" + "// dgvc{0}",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "// ");
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.DataPropertyName = \"{0}\";",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.HeaderText = \"{1}\";",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName,
                            ObjLstViewRegionFldsEx.HeaderText);
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.Name = \"dgvc{0}\";",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n" + "this.dgvc{0}.Visible = true;",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                // 
                // gbQueryCondition
                // 
                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.Controls.Add({0});",
                        strCtlName);
                }
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnExportExcel4Dg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnQuery);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnUpdate);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnAdd);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.btnDelRec);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblMsg);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Controls.Add(this.lblRecNum);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Location = new System.Drawing.Point(0, 0);");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Name = \"gbQueryCondition\";");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Size = new System.Drawing.Size(720, 176);");
                strCodeForCs.AppendFormat("\r\n" + "this.gbQueryCondition.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.TabStop = false;");
                strCodeForCs.Append("\r\n" + "this.gbQueryCondition.Text = \"��ѯ����\";");

                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                // 
                // frm{0}_QD_LV
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_QD_LV",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                //				strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.Append("\r\n" + "this.ClientSize = new System.Drawing.Size(1000, 700);");
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.dgv{0});",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.gbQueryCondition);");
                strCodeForCs.Append("\r\n" + "this.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");

                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_QD_LV\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_QD_LV\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;");

                strCodeForCs.AppendFormat("\r\n" + "this.Load +=  new System.EventHandler(this.frm{0}_QD_Load);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //������:���ɿؼ����ڲ��ؼ�����������

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }


                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnQuery;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnUpdate;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnAdd;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnDelRec;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnExportExcel4Dg;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Label lblRecNum;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.GroupBox gbQueryCondition;");

                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGridView dgv{0};",
                    objViewInfoENEx.TabName_Out);

                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGridViewTextBoxColumn dgvc{0};",
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                //���߲�:����this.load����

                //���һ��:������Ľ������������ռ�Ľ�����
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //������д���ļ���;
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();

        }
     

       
    
        /// <summary>
        /// �������ڱ༭ĳ����Ľ���,����:�޸ġ����,�ý�����Ҫ���ڱ���������������
        /// ע:��ʹ�ÿؼ�(NoContral)
        /// </summary>
        /// <returns></returns>
        public string A_GenUpdInsRecCode_NoContral_Net2005_Design()
        {
            Point pntLocation = new Point();
            ArrayList arrInnerCtlSet = new ArrayList();		//�ڲ��ؼ�����

            //���û���������;
            StringBuilder strCodeForCs = new StringBuilder();    ///�������WebForm�Ĵ���;
            //			string strTemp ;          ///��ʱ����;
            clsDataGridStyleENEx objDGStyleEx = clsDataGridStyleBLEx.GetDataGridStyleEXExObjByDgStyleId(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsBiDimDistribute objBiDimDistribute = new clsBiDimDistribute();
            objBiDimDistribute.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;
            objBiDimDistribute.ColWidth = 250;
            objBiDimDistribute.LineHeight = 35;
            int intLblHeight = 18;
            int intLblWidth = 70;
            int intTxtHeight = 20;
            int intTxtWidth = 100;

            float fltCtlWidth = objBiDimDistribute.GetCtlWidth();
            float fltCtlHeight = objBiDimDistribute.GetCtlHeigh(objViewInfoENEx.objViewRegion_Edit.FieldNum());

            //���༭����
            CheckEditRegion();

            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_UI";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "frm" + objViewInfoENEx.TabName + "_UI.Designer.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            try
            {

                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                        objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                    }
                }

                //��һ��:���ɵ��������ռ�


                //������ʼ
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //�ڶ���:���ɿؼ�����
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_UI ��ժҪ˵����", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "partial class frm{0}_UI", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                //���Ĳ�:���ɱ�������������
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// ����������������");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                //���岽:������������ʹ�õ���Դ
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// ������������ʹ�õ���Դ��");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components !=  null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //������:�����������ɵĴ���

                strCodeForCs.Append("\r\n" + "#region �����������ɵĴ���");
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// �����֧������ķ��� - ��Ҫʹ�ô���༭�� ");
                strCodeForCs.Append("\r\n /// �޸Ĵ˷��������ݡ�");
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                        objEditRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                        objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
                }

                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnClose = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
                objBiDimDistribue.StartX = 10;
                objBiDimDistribue.StartY = 10;
                objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;
                objBiDimDistribue.ColWidth = 250;
                objBiDimDistribue.LineHeight = 30;
                int intFieldIndex = 0;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                // 
                                // checkBox1
                                // 
                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objEditRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objEditRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                            case "ComboBox":
                            case "DropDownList":
                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objEditRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objEditRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objEditRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.FldName,
                                    objEditRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objEditRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;",
                                        objEditRegionFldsEx.CtrlId4Win);

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objEditRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objEditRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objEditRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;

                            default:

                                //����ؼ���Ӧ��Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objEditRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objEditRegionFldsEx.FldName,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                    objEditRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objEditRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                    objEditRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                    objEditRegionFldsEx.FldName,
                                    objEditRegionFldsEx.LabelCaption);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this.lbl" + objEditRegionFldsEx.FldName);

                                //����ؼ�
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                    objEditRegionFldsEx.CtrlId4Win,
                                    objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                    objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                    objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                    objEditRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                    objEditRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                    objEditRegionFldsEx.CtrlId4Win);
                                //�ѵ�ǰ�ڲ��ؼ�����ڲ��ؼ�������
                                arrInnerCtlSet.Add("this." + objEditRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                                //end of switch
                        }
                        //end of if(objEditRegionFldsEx.IsIdentity  ==  false && objEditRegionFldsEx.IsCtlField  ==  true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objEditRegionFldsEx in arrViewCtlFldSet)
                    intFieldIndex++;
                }



                // 
                // btnOKUpd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnOKUpd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.Location = new System.Drawing.Point({0}, {1});",
                    fltCtlWidth / 4,
                    fltCtlHeight + 30);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Name = \"btnOKUpd\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Size = new System.Drawing.Size(80, 30);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Text = \"���\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Click +=  new System.EventHandler(this.btnOKUpd_Click);");

                // 
                // btnClose
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnClose");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnClose.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.Location = new System.Drawing.Point({0}, {1});",
                    fltCtlWidth / 4 + 120,
                    fltCtlHeight + 30);
                strCodeForCs.Append("\r\n" + "this.btnClose.Name = \"btnClose\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Size = new System.Drawing.Size(80, 30);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.TabIndex = {0};",
                    intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnClose.Text = \"�ر�\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Click +=  new System.EventHandler(this.btnClose_Click);");
                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.Location = new System.Drawing.Point({0}, {1});",
                    fltCtlWidth / 4,
                    fltCtlHeight + 60);
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                    intIndex++);

                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_UI",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.AppendFormat("\r\n" + "this.ClientSize = new System.Drawing.Size({0}, {1});",
                    fltCtlWidth + 30,
                    fltCtlHeight + 100);
                //��ؼ����ڲ��ؼ�����������ڲ��ؼ�
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add({0});",
                        strCtlName);
                }


                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnClose);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnOKUpd);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.lblMsg);");
                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_UI\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;");
                strCodeForCs.Append("\r\n" + "this.Font = new System.Drawing.Font(\"����\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");

                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_UI\";",
                    objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Load +=  new System.EventHandler(this.frm{0}_UI_Load);",
                    objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //������:���ɿؼ����ڲ��ؼ�����������

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objEditRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.objCtlType.CtlTypeName);
                }
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnOKUpd;");
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnClose;");

                //���һ��:������Ľ������������ռ�Ľ�����
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //������д���ļ���;
            //�����ļ������ļ�����,���ж��Ƿ����;

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }


        ///���¾��ǽ��������(VIEW) ==  == = 

        public string A_GenViewCode_Win_New(Encoding myEncoding, clsViewInfoENEx objViewInfoENEx)
        {
            //switch ((enumViewTypeCodeTab)objViewInfoENEx.ViewTypeCode)
            //{
            //    case enumViewTypeCodeTab.Table_Update_2:// "0002":	//�����޸�
            //                                          //return A_GenUpdRecCode();
            //    case enumViewTypeCodeTab.Table_Query_3:// "0003":	//�����ѯ
            //                                         //return A_GenQueryRecCode(myEncoding, objViewInfoENEx);

            //    case enumViewTypeCodeTab.Table_QD_InvokeUI_GridView_20:// "0020":	//�����QUDI_GridView
            //                                                        //return A_GenQueryUpdDelInsRecCode();
            //    case enumViewTypeCodeTab.Table_QUDI_4:// "0004":	//�����QUDI
            //                                        //return A_GenQueryUpdDelInsRecCode();
            //                                        //case enumViewTypeCodeTab.Table_QUDI_LV:// "0008":	//�����QUDI_LV,Windows��,��ʾ��ListView
            //                                        //return A_GenQueryUpdDelInsRecCodeWithLV_New();
            //                                        //case enumViewTypeCodeTab.Table_UI_9:// "0009":	//�����UI,����༭,����:�޸ġ����
            //                                        //    return A_GenUpdInsRecCode();
            //                                        //case enumViewTypeCodeTab.Table_QD_InvokeUI:// "0010":	//�����QD,����UI,����༭,����:�޸ġ����
            //                                        //return A_GenQueryDelAffitUpdInsRecCodeWithLV();
            //    case enumViewTypeCodeTab.Table_QD_InvokeUI_ListView_11:// "0011":	//�������Ͻ���,����������(��ѯ��ɾ��)���ӽ���(�޸ġ����)QD,����UI,����༭,����:�޸ġ����
            //        if (objViewInfoENEx.MainSubViewType == clsPubConst.MainSubViewType.MainView && objViewInfoENEx.IsUseCtl == true)
            //        {
            //            //return A_GenQueryDelAffitUpdInsRecCodeWithLV();
            //        }
            //        else if (objViewInfoENEx.MainSubViewType == clsPubConst.MainSubViewType.MainView && objViewInfoENEx.IsUseCtl == false)
            //        {
            //            //if (objViewInfoENEx.NetVersion == "2005")
            //            //{
            //                if (objViewInfoENEx.IsDesign)
            //                {
            //                    return A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral_Net2005_Design();
            //                }
            //                else
            //                {
            //                    return A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral_Net2005();
            //                }
            //            //}
            //            //else
            //            //{
            //            //    return A_GenQueryDelAffitUpdInsRecCodeWithLV_NoContral();
            //            //}
            //        }
            //        else if (objViewInfoENEx.MainSubViewType == clsPubConst.MainSubViewType.SubView && objViewInfoENEx.IsUseCtl == true)
            //        {
            //            //return A_GenUpdInsRecCode();
            //        }
            //        else if (objViewInfoENEx.MainSubViewType == clsPubConst.MainSubViewType.SubView && objViewInfoENEx.IsUseCtl == false)
            //        {
            //            //if (objViewInfoENEx.NetVersion == "2005")
            //            //{
            //                if (objViewInfoENEx.IsDesign)
            //                {
            //                    return A_GenUpdInsRecCode_NoContral_Net2005_Design();
            //                }
            //                else
            //                {
            //                    return A_GenUpdInsRecCode_NoContral_Net2005();
            //                }
            //            //}
            //            //else
            //            //{
            //            //    return A_GenUpdInsRecCode_NoContral();
            //            //}
            //        }
            //        break;
            //    default:
            //        clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCodeCache(objViewInfoENEx.ViewTypeCode);
            //        string strMsg = string.Format("�������ͣ�[{0}({1})]�ں���:[{2}]��û�б�����,����ϵ����Ա!",
            //            objViewTypeCodeTabEN.ViewTypeName,
            //            objViewInfoENEx.ViewTypeCode,
            //            clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //}
            return "";
        }

  
        public string GenCombineCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public string Combine{0}Condition()", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {1}.{0} = '1'\";",
                                objQryRegionFldsEx.FldName, objViewInfoENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {1}.{0} = '0'\";",
                                objQryRegionFldsEx.FldName, objViewInfoENEx.TabName);
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "ComboBox":    ///����ؼ���������;
							if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex  ==  1)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0}.{1} = '1'\"; ",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex  ==  2)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0}.{1} = '0'\";",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue.ToString()!= \"\" && this.{1}.SelectedValue.ToString()!= \"0\")",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.SelectedValue+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox":     ///����ؼ��������ı���;
							if ((objQryRegionFldsEx.QueryOptionId == "00") || (objQryRegionFldsEx.QueryOptionId == "01"))    ///��Ȳ�ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "02")      ///ģ����ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} like '%\" + this.{1}.Text.Trim()+\"%'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "03")
                            {      ///��Χ��ѯ;
								strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                    }
                }
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenCombineConditionWithSel()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public string Combine{0}Condition(bool bolIsWithTabName)", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");
                strCodeForCs.Append("\r\n" + "if (bolIsWithTabName  ==  true)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {1}.{0} = '1'\";",
                                objQryRegionFldsEx.FldName, objViewInfoENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {1}.{0} = '0'\";",
                                objQryRegionFldsEx.FldName, objViewInfoENEx.TabName);
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "ComboBox":    ///����ؼ���������;
							if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex  ==  1)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0}.{1} = '1'\"; ",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex  ==  2)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0}.{1} = '0'\";",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue.ToString()!= \"\" && this.{1}.SelectedValue.ToString()!= \"0\")",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.SelectedValue+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox":     ///����ؼ��������ı���;
							if ((objQryRegionFldsEx.QueryOptionId == "00") || (objQryRegionFldsEx.QueryOptionId == "01"))    ///��Ȳ�ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "02")      ///ģ����ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} like '%\" + this.{1}.Text.Trim()+\"%'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "03")
                            {      ///��Χ��ѯ;
								strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {2}.{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, objViewInfoENEx.TabName);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '1'\";",
                                objQryRegionFldsEx.FldName);
                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '0'\";",
                                objQryRegionFldsEx.FldName);
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "ComboBox":    ///����ؼ���������;
							if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex  ==  1)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '1'\"; ",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex  ==  2)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '0'\";",
                                    objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue.ToString()!= \"\" && this.{1}.SelectedValue.ToString()!= \"0\")",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '\" + this.{1}.SelectedValue+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox":     ///����ؼ��������ı���;
							if ((objQryRegionFldsEx.QueryOptionId == "00") || (objQryRegionFldsEx.QueryOptionId == "01"))    ///��Ȳ�ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "02")      ///ģ����ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} like '%\" + this.{1}.Text.Trim()+\"%'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "03")
                            {      ///��Χ��ѯ;
								strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And {0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenCombineConditionWithTabName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// �����еĲ�ѯ�ؼ�������ϳ�һ��������");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public string Combine{0}Condition(string strTabName)", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {1} + \".{0} = '1'\";",
                                objQryRegionFldsEx.FldName, "strTabName");
                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {1} + \".{0} = '0'\";",
                                objQryRegionFldsEx.FldName, "strTabName");
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "ComboBox":    ///����ؼ���������;
							if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex  ==  1)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {0} + \".{1} = '1'\"; ",
                                    "strTabName", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex  ==  2)",
                                    objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {0} + \".{1} = '0'\";",
                                    "strTabName", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue.ToString()!= \"\" && this.{1}.SelectedValue.ToString()!= \"0\")",
                                    objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {2} + \".{0} = '\" + this.{1}.SelectedValue+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, "strTabName");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox":     ///����ؼ��������ı���;
							if ((objQryRegionFldsEx.QueryOptionId == "00") || (objQryRegionFldsEx.QueryOptionId == "01"))    ///��Ȳ�ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {2} + \".{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, "strTabName");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "02")      ///ģ����ѯ;
							{
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {2} +\".{0} like '%\" + this.{1}.Text.Trim()+\"%'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, "strTabName");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "03")
                            {      ///��Χ��ѯ;
								strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {2} +\".{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, "strTabName");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond +=  \" And \" + {2} + \".{0} = '\" + this.{1}.Text.Trim()+\"'\";",
                                    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win, "strTabName");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                    }
                }
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //��ʮ��:���ɻ�ȡListView�е�ǰ�е�����ֵ��
        /// <summary>
        /// ����LISTVIEW �е�����������
        /// </summary>
        /// <returns></returns>

      
    }
}

