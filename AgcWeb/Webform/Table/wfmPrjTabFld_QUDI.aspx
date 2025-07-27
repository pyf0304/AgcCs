<%@ Page Language="c#" CodeBehind="wfmPrjTabFld_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrjTabFld_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucPrjTabFld" Src="wucPrjTabFld.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>�PrjTabFld�Ĳ�ѯ���޸ġ�ɾ����Ӽ�¼</title>
    

    <script language="javascript" type="text/javascript">
		<!--
	function radioClick()
	{
		if (document.Form1.RadioName !=null)
		{
			for (i=0; i<document.Form1.RadioName.length; i++)
			{
			    if (document.Form1.RadioName[i].checked == true)
			    {
					document.Form1.rd.value = document.Form1.RadioName[i].value;
					//document.getElementById("TextBox1").value = document.Form1.rd.value;
				}
			}
		}
	}
		//-->
    </script>


    
    
    

</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
        </asp:ScriptManager>
        &nbsp;
        <asp:Label ID="Label3" Style="z-index: 103; left: 8px; position: absolute; top: 8px"
            runat="server" Width="200px" CssClass="h5">���ֶι��->��ά���ֶ</asp:Label>
        <asp:Label ID="Label6" Style="z-index: 112; left: 215px; position: absolute; top: 9px"
            runat="server" CssClass="text-secondary" Width="69px">ι��̱���</asp:Label>
        <asp:LinkButton ID="lbReturn" Style="z-index: 106; left: 803px; position: absolute;
            top: 7px" runat="server" Width="32px" OnClick="lbReturn_Click">Ʒ��</asp:LinkButton>
        &nbsp;&nbsp;
        <table id="tabWhole" style="z-index: 110; left: 4px; width: 560px; position: absolute;
            top: 31px" cellspacing="1" cellpadding="1" width="560" border="1">
            <tr>
                <td>
                    <table id="tabPrjTabFld" style="width: 448px;" cellspacing="0" cellpadding="0" width="448"
                        border="0" runat="server">
                        <tr>
                            <td colspan="2">
                                <div style="width: 787px; position: relative; height: 49px; left: 0px; top: 0px;">
                                    <asp:Button ID="btnAdd" Style="z-index: 101; left: 292px; position: absolute; top: 0px"
                                        runat="server" Text="���ӱ��ֶ" OnClick="btnAdd_Click" Width="90px"></asp:Button>
                                    <asp:Button ID="btnSetTabFldProperty" Style="z-index: 102; left: 491px; position: absolute;
                                        top: 0px" runat="server" Text="����ñ��ֶ" OnClick="btnSetProperty_Click" Width="86px"></asp:Button>
                                    <asp:Button ID="btnDelRec" Style="z-index: 103; left: 388px; position: absolute;
                                        top: 0px" runat="server" Text="�ɾ����ֶ" OnClick="btnDelRec_Click" Width="92px"></asp:Button>
                                    &nbsp;&nbsp;
                                    <asp:Button ID="Button1" Style="z-index: 105; left: 592px; position: absolute;
                                        top: 2px" runat="server" Text="������ֶ����" OnClick="btnSetFldProperty_Click" Width="107px"></asp:Button>
                                    <asp:Button ID="btnExportExcel" Style="z-index: 106; left: 704px; position: absolute;
                                        top: 2px" runat="server"   Text="Ե��Excel" OnClick="btnExportExcel_Click">
                                    </asp:Button>
                                    <asp:Label ID="Label7" Style="z-index: 107; left: 6px; position: absolute; top: 1px"
                                        runat="server" CssClass="h6">�̱��ֶ��б</asp:Label>
                                    <asp:LinkButton ID="lbSynchWithTab" Style="z-index: 108; left: 415px; position: absolute;
                                        top: 32px" runat="server" OnClick="lbSynchWithTab_Click" ToolTip="�ѱ�����ض���������ֶ���ȫͬ������ʹ���������ֶ��б���ȫһ�">�����ض���ͬ���ֶ</asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="lbCheckConsistency" runat="server" OnClick="lbCheckConsistency_Click"
                                        Style="z-index: 104; left: 220px; position: absolute; top: 2px">μ��һ���</asp:LinkButton>
                                    <asp:LinkButton ID="lbMoveRecTo" Style="z-index: 103; left: 5px; position: absolute;
                                        top: 29px" runat="server"   OnClick="lbMoveRecTo_Click">��ƶ���¼����</asp:LinkButton>
                                    <asp:RadioButtonList ID="rblSeqNum" Style="z-index: 104; left: 81px; position: absolute;
                                        top: 25px" runat="server" Width="168px"  RepeatDirection="Horizontal"
                                        CssClass="Radio_Defa">
                                        <asp:ListItem Value="��һ">��һ</asp:ListItem>
                                        <asp:ListItem Value="��">���</asp:ListItem>
                                        <asp:ListItem Value="�ڼ�">�ڼ�</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <asp:TextBox ID="txtRecSeqNum" Style="z-index: 105; left: 252px; position: absolute;
                                        top: 25px" runat="server" Width="42px">0</asp:TextBox>
                                    <asp:CompareValidator ID="CompareValidator1" Style="z-index: 117; left: 307px; position: absolute;
                                        top: 30px" runat="server" Width="96px"  Operator="DataTypeCheck" Type="Integer"
                                        ControlToValidate="txtRecSeqNum" ErrorMessage="�������������!" CssClass="text-warning" ForeColor=""></asp:CompareValidator>
                                    <asp:LinkButton ID="lbGeneLogicCodeEx" runat="server" OnClick="lbGeneLogicCodeEx_Click"
                                        Style="z-index: 102; left: 644px; position: absolute; top: 32px" Width="120px">����ͨ���չ�߼��</asp:LinkButton>
                                    <asp:LinkButton ID="lbGeneLogicCode" runat="server" OnClick="lbGeneLogicCode_Click"
                                        Style="z-index: 103; left: 541px; position: absolute; top: 30px">����ͨ���߼��</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                &nbsp;<asp:GridView ID="gvPrjTabFld" runat="server" AllowPaging="True" AllowSorting="True"
                                    AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                                    BorderWidth="1px" CellPadding="3" CssClass="table table-striped table-bordered table-condensed" DataKeyNames="mId" GridLines="Horizontal"
                                    Height="1px" OnPageIndexChanging="gvPrjTabFld_PageIndexChanging" OnRowCommand="gvPrjTabFld_RowCommand"
                                    OnRowCreated="gvPrjTabFld_RowCreated" OnRowDeleting="gvPrjTabFld_RowDeleting"
                                    OnRowUpdating="gvPrjTabFld_RowUpdating" OnSorting="gvPrjTabFld_Sorting" Width="800px" OnRowDataBound="gvPrjTabFld_RowDataBound">
                                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="�ȫѡ">
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap text-white">ȫѡ</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle Width="35px" />
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="SequenceNumber" HeaderText="��" SortExpression="SequenceNumber" />
                                        <asp:BoundField DataField="FldName" HeaderText="��ֶ��" SortExpression="FldName" />
                                        <asp:BoundField DataField="Caption" HeaderText="���" SortExpression="Caption" />
                                        <asp:BoundField DataField="DataTypeName" HeaderText="����" SortExpression="DataTypeName" />
                                        <asp:BoundField DataField="FldLength" HeaderText="ͳ��" SortExpression="FldLength" />
                                        <asp:BoundField DataField="IsTabNullable" HeaderText="ȿɿ?" SortExpression="IsTabNullable" />
                                        
                                        <asp:BoundField DataField="PrimaryTypeName" HeaderText="�������" SortExpression="PrimaryTypeName" />
                                        <asp:BoundField DataField="FieldTypeName" HeaderText="��ֶ����" SortExpression="FieldTypeName" />
                                        <asp:BoundField DataField="IsTabUnique" HeaderText="�Ψһ" SortExpression="IsTabUnique" />
                                        <asp:BoundField DataField="IsTabForeignKey" HeaderText="��?" SortExpression="IsTabForeignKey" />
                                        <asp:BoundField DataField="IsParentObj" HeaderText="���?" SortExpression="IsParentObj" />
                                        <asp:BoundField DataField="ForeignTabName" HeaderText="����" SortExpression="ForeignTabName" />
                                        <asp:BoundField DataField="TabName" HeaderText="���" SortExpression="TabName" Visible="False" />
                                        <asp:BoundField DataField="IsNull" HeaderText="�ɿ" SortExpression="IsNull" Visible="False" />
                                        <asp:BoundField DataField="CodeTab" HeaderText="մ���" SortExpression="CodeTab" Visible="False" />
                                        <asp:BoundField DataField="CodeTabName" HeaderText="����_���" SortExpression="CodeTabName"
                                            Visible="False" />
                                        <asp:BoundField DataField="CodeTabCode" HeaderText="ƴ���_���" SortExpression="CodeTabCode"
                                            Visible="False" />
                                        <asp:BoundField DataField="DefaultValue" HeaderText="�ȱʡֵ" SortExpression="DefaultValue"
                                            Visible="False" />
                                        <asp:BoundField DataField="MinValue" HeaderText="��Сֵ" SortExpression="MinValue" Visible="False" />
                                        <asp:BoundField DataField="MaxValue" HeaderText="���ֵ" SortExpression="MaxValue" Visible="False" />
                                    </Columns>
                                    <PagerTemplate>
                                        <span style="background-color: #c0c0c0">���м�¼:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                            Width="46px">0</asp:Label>
                                        <span style="background-color: #c0c0c0">
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                        </span><span style="background-color: #c0c0c0">��ҳ�:</span>
                                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <span style="background-color: #c0c0c0">�ǰҳ:</span>
                                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnPrevPage" runat="server" CommandArgument="Prev" CommandName="Page"
                                            CssClass="btn btn-outline-warning btn-sm small" Text="��һҳ" Width="50px" /><span style="font-family: Verdana">
                                            </span>
                                        <asp:Button ID="btnNextPage" runat="server" CommandArgument="Next" CommandName="Page"
                                            CssClass="btn btn-outline-warning btn-sm small" Text="��һҳ" Width="50px" />
                                        ���
                                        <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>�ҳ
                                        <asp:Button ID="btnJumpPage" runat="server" CommandName="Page" CssClass="btn btn-outline-warning btn-sm small"
                                            OnClick="btnJumpPage_Click" Text="ȷ��" Width="35px" />
                                        <span style="background-color: #c0c0c0">ҳ��¼�:</span>
                                        <asp:DropDownList ID="ddlPagerRecCount" runat="server" AutoPostBack="True" CssClass="DropDown_DefaInPager"
                                            OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged" Width="41px">
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>20</asp:ListItem>
                                            <asp:ListItem>30</asp:ListItem>
                                            <asp:ListItem>50</asp:ListItem>
                                            <asp:ListItem>100</asp:ListItem>
                                            <asp:ListItem>1000</asp:ListItem>
                                            <asp:ListItem></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                            ErrorMessage="���" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                    </PagerTemplate>
                                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <AlternatingRowStyle BackColor="#F7F7F7" />
                                </asp:GridView>
                            </td>
                            <td>
                                <div style="width: 33px; position: relative; height: 136px; left: 2px; top: 24px;">
                                    <asp:ImageButton ID="ibDown" Style="z-index: 101; left: 0px; position: absolute;
                                        top: 48px" runat="server" Width="24px" Height="28px" ImageUrl="~/pic/Down.JPG" OnClick="ibDown_Click">
                                    </asp:ImageButton>
                                    <asp:ImageButton ID="ibUp" Style="z-index: 102; left: 0px; position: absolute; top: 8px"
                                        runat="server" Width="24px" Height="28px" ImageUrl="~/pic/Up.JPG" OnClick="ibUp_Click"></asp:ImageButton>
                                    <asp:Button ID="btnReOrder" Style="z-index: 103; left: 0px; position: absolute; top: 81px"
                                        runat="server" Width="30px" Height="40px" Text="����" OnClick="btnReOrder_Click"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div style="width: 696px; position: relative; height: 26px">
                                    &nbsp;
                                    <asp:Label ID="lblMsg2" runat="server" ForeColor="Red" Width="85px" 
                                        Style="z-index: 102; left: 584px; position: absolute; top: 0px"></asp:Label>
                                    &nbsp; &nbsp;&nbsp;
                                </div>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                &nbsp;</td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditPrjTabFld" cellspacing="1" cellpadding="1" width="240" border="1"
                        runat="server" style="width: 240px; height: 83px">
                        <tr>
                            <td>
                                <div style="width: 760px; position: relative; height: 26px">
                                    <asp:Button ID="btnOKEdit" Style="z-index: 101; left: 595px; position: absolute;
                                        top: 0px" runat="server" Text="�ȷ���޸" OnClick="btnOKEdit_Click" Width="83px"></asp:Button>
                                    <asp:Label ID="lblMsgEdit" Style="z-index: 102; left: 247px; position: absolute; top: 8px"
                                        runat="server" Width="345px"  CssClass="text-warning"></asp:Label>
                                    <asp:Label ID="Label8" Style="z-index: 103; left: 0px; position: absolute; top: 8px"
                                        runat="server" CssClass="text-secondary">Ĺ��̱��ֶα༭</asp:Label>
                                    <asp:LinkButton ID="lbDispTabFld2" Style="z-index: 104; left: 688px; position: absolute;
                                        top: 8px" runat="server" OnClick="lbDispTabFld2_Click">��ʾ���ֶ</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucPrjTabFld ID="wucPrjTabFld1" runat="server"></uc1:wucPrjTabFld>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabFieldTab" cellspacing="1" cellpadding="1" border="0" runat="server" style="width: 474px">
                        <tr>
                            <td style="font-family: Verdana; height: 18px">
                                <div style="width: 802px; position: relative; height: 66px">
                                    <asp:LinkButton ID="lbDispTabFld" runat="server" Style="z-index: 100; left: 731px;
                                        position: absolute; top: 8px" OnClick="lbDispTabFld_Click">���ʾ���ֶ</asp:LinkButton>
                                    <asp:DropDownList ID="ddlPrjObject" runat="server" Width="189px" AutoPostBack="True"
                                        Style="z-index: 101; left: 155px; position: absolute; top: 3px" OnSelectedIndexChanged="ddlPrjObject_SelectedIndexChanged">
                                    </asp:DropDownList>
                                    <asp:Label ID="Label9" Style="z-index: 102; left: 114px; position: absolute; top: 6px"
                                        runat="server" Width="35px"  Font-Names="����" CssClass="text-secondary">���</asp:Label>
                                    <asp:Label ID="Label10" Style="z-index: 103; left: 4px; position: absolute; top: 10px"
                                        runat="server" CssClass="text-secondary">�Դ�����ֶ��б</asp:Label>
                                    <asp:Button ID="btnOkAdd" Style="z-index: 106; left: 648px; position: absolute; top: 2px"
                                        runat="server" Text="�ȷ����" OnClick="btnOkAdd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg1" Style="z-index: 105; left: 692px; position: absolute; top: 31px"
                                        runat="server" ForeColor="Red" Width="105px" CssClass="text-warning"></asp:Label>
                                    <asp:TextBox ID="txtFldName" runat="server" class="form-control-sm"
                                        Style="left: 406px; position: relative; top: 0px" Width="109px"></asp:TextBox>
                                    <asp:Label ID="lblFldID" runat="server" Style="left: 232px; position: relative; top: 0px">��ֶ���</asp:Label>
                                    <asp:Button ID="btnQuery" runat="server"  OnClick="btnQuery_Click" Style="left: 353px;
                                        position: relative; top: 0px" Text="Ʋ�ѯ" Width="63px" /></div>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:DataGrid ID="dgObjFld4Sel" runat="server" Width="807px" AllowPaging="True" AutoGenerateColumns="False"
                                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" BackColor="White"
                                    CellPadding="1" CellSpacing="1" AllowSorting="True" CssClass="table table-striped table-bordered table-condensed" OnItemCreated="dgObjFld4Sel_ItemCreated" OnItemDataBound="dgObjFld4Sel_ItemDataBound" OnPageIndexChanged="dgObjFld4Sel_PageIndexChanged" OnSortCommand="dgObjFld4Sel_SortCommand">
                                    <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
                                    <ItemStyle ForeColor="#000066"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="ѡ�">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="ckb1" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn Visible="False" DataField="FldId" HeaderText="��ֶα�"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="��ֶ���"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Caption" HeaderText="Ʊ��"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="��ֶ����">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldLength" SortExpression="FldLength" HeaderText="��ֶγ��">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsNull" SortExpression="IsNull" HeaderText="��Ƿ�Ϊ�"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td>
                                <div id="divTabFld4Sel" style="width: 184px; position: relative; height: 22px">
                                    <asp:Label ID="Label5" Style="z-index: 101; left: 0px; position: absolute; top: 0px"
                                        runat="server" Width="56px"  Font-Names="����" Font-Size="Smaller">��¼�</asp:Label>
                                    <asp:TextBox ID="txtRecCount_PrjTabFld" Style="z-index: 102; left: 64px; position: absolute;
                                        top: 0px" runat="server"  Font-Names="����" Font-Size="Smaller"
                                        ReadOnly="True" CssClass="TextBox_Defa"></asp:TextBox>
                                    <asp:CheckBox ID="chkSelAll" Style="z-index: 103; left: 120px; position: absolute;
                                        top: 0px" runat="server" AutoPostBack="True" Text="�ȫѡ" CssClass="text-secondary" OnCheckedChanged="chkSelAll_CheckedChanged"></asp:CheckBox>
                                </div>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblCurrTabName" Style="z-index: 111; left: 291px; position: absolute;
            top: 9px" runat="server" Width="352px" Font-Bold="True" CssClass="ValueLabelH1">Label</asp:Label>        
        <asp:Label ID="lblMsgList" Style="z-index: 108; left: 644px; position: absolute; top: 9px"
            runat="server" Width="150px" CssClass="text-warning"></asp:Label>
    </form>
</body>
</html>
