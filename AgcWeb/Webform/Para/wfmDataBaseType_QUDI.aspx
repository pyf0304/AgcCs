<%@ Page Language="c#" CodeBehind="wfmDataBaseType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmDataBaseType_QUDI" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register TagPrefix="uc1" TagName="wucDataBaseType" Src="wucDataBaseType.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>��DataBaseType�Ĳ�ѯ���޸ġ�ɾ������Ӽ�¼</title>

    <script type="text/javascript" language="javascript">
        var checknum = 0;
        function CheckClick(iIndex) {
            //var strName = this.Id;
            //     var x=document.getElementById("chkCheckRec")
            //  alert(x.innerHTML)

            var x = event.srcElement.id;
            var objCheckBox = document.getElementById(x)
            if (objCheckBox.checked == true) {
                checknum = checknum + 1;
            }
            else {
                checknum = checknum - 1;
            }
            //event.srcElement.tagName 
            //"INPUT"
            //event.srcElement.type 
            //"checkbox"
            //event.srcElement.Id
            //undefined
            //event.srcElement.ID
            //undefined
            //event.srcElement.id
            //"gvStudent_ctl02_chkCheckRec"
            //event.srcElement.checked
            //true

//            alert("��ѡ���ˣ�" + checknum);
            if (checknum >= 1) {
                $find("ConfirmButtonExtender2").set_ConfirmText("��ȷ��Ҫɾ����Щ��¼��?");
            }
            else {
                $find("ConfirmButtonExtender2").set_ConfirmText("��ѡ����Ҫɾ���ļ�¼!");
            }
            //    alert(objCheckBox.checked);
        }
        function SetConfirmText(ss) {
            $find("ConfirmButtonExtender2").set_ConfirmText(ss);
        }
        function Button1_onclick() {
            $find("ConfirmButtonExtender2").set_ConfirmText("AAA");
            //alert("AAA");
        }
    </script>

    
</head>
<body>
    <form id="Form1" method="post" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblViewTile" Style="z-index: 101; left: 16px; position: absolute;
                top: 8px" runat="server" Font-Names="����" Font-Size="Small" CssClass="h5">���ݿ�����ά��</asp:Label>
            <table id="Table1" style="z-index: 102; left: 8px; width: 736px; position: absolute;
                top: 40px" cellspacing="0" cellpadding="0" width="736" border="0">
                <tr>
                    <td colspan="3">
                        <table id="tabDataBaseTypeDataGrid" style="width: 736px" bordercolor="#996666" cellspacing="1"
                            cellpadding="1" width="736" border="4" runat="server">
                            <tr>
                                <td style="height: 26px">
                                    <div id="divDataBaseType" style="width: 721px; position: relative; height: 32px"
                                        runat="server">
                                        <asp:Label ID="lblDataBaseTypeIdq" Style="z-index: 104; left: 0px; position: absolute;
                                            top: 8px; width: 200px;" runat="server" >
  ���ݿ�����ID</asp:Label>
                                        <asp:TextBox ID="txtDataBaseTypeIdq" Style="z-index: 105; left: 96px; position: absolute;
                                            top: 8px" runat="server" Width="160px" ></asp:TextBox>
                                        <asp:Label ID="lblDataBaseTypeNameq" Style="z-index: 107; left: 328px; position: absolute;
                                            top: 8px" runat="server"  >
  ���ݿ�������</asp:Label>
                                        <asp:TextBox ID="txtDataBaseTypeNameq" Style="z-index: 108; left: 416px; position: absolute;
                                            top: 8px" runat="server" Width="152px" ></asp:TextBox>
                                        <asp:Button ID="btnQuery" Style="z-index: 113; left: 648px; position: absolute; top: 8px"
                                            runat="server" Width="72px"  Text="��ѯ"></asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 40px">
                                    <div style="display: inline; width: 721px; position: relative; height: 28px">
                                        <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 103; left: 400px; position: absolute;
                                            top: 0px" runat="server"   Text="��Ӽ�¼"></asp:Button>
                                        <asp:Button ID="btnDelete4Dg" Style="z-index: 101; left: 480px; position: absolute;
                                            top: 0px" runat="server"   Text="ɾ����¼"></asp:Button>
                                       
                                        <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender2" runat="server" 
                                                 TargetControlID="btnDelete4Dg"
                    ConfirmText="Are you sure you want to click the Button?" />
                                        <asp:Button ID="btnUpdate4Dg" Style="z-index: 102; left: 560px; position: absolute;
                                            top: 0px" runat="server"   Text="�޸ļ�¼"></asp:Button>
                                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 104; left: 640px; position: absolute;
                                            top: 0px" runat="server"   Text="����Excel"></asp:Button>
                                        <asp:Label ID="lblRegionViewTitle" Style="z-index: 105; left: 8px; position: absolute;
                                            top: 8px; width: 169px;" runat="server" CssClass="h6">���ݿ������б��</asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" align="left">
                                    <asp:DataGrid ID="dgDataBaseType" runat="server" Width="720px" AutoGenerateColumns="False"
                                        AllowPaging="True" AllowSorting="True" BorderColor="#E7E7FF" BorderStyle="None"
                                        BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" 
                                        onitemcommand="dgDataBaseType_ItemCommand" 
                                        onitemcreated="dgDataBaseType_ItemCreated">
                                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                        <Columns>
                                            <asp:TemplateColumn HeaderText="ѡ��">
                                                <HeaderStyle Width="30px"></HeaderStyle>
                                                <HeaderTemplate>
                                                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server">ȫѡ</asp:LinkButton>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn DataField="DataBaseTypeId" SortExpression="DataBaseTypeId" HeaderText="���ݿ�����ID">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="DataBaseTypeName" SortExpression="DataBaseTypeName" HeaderText="���ݿ�������">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="˵��"></asp:BoundColumn>
                                            <asp:ButtonColumn Text="�޸�" CommandName="Update"></asp:ButtonColumn>
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="ɾ��"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                        </Columns>
                                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                        </PagerStyle>
                                    </asp:DataGrid>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 605px" bgcolor="silver">
                                    <table id="tabDataBaseTypeJumpPage" style="width: 648px; font-family: Verdana; height: 26px"
                                        cellspacing="0" cellpadding="0" width="648" border="0" runat="server">
                                        <tr>
                                            <td>
                                                <font face="����"><font style="background-color: #c0c0c0">���м�¼:</font>
                                                    <asp:Label ID="lblDataBaseTypeRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">��ҳ��:</font>
                                                    <asp:Label ID="lblDataBaseTypeAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">��ǰҳ:
                                                        <asp:Label ID="lblDataBaseTypeCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                        <div style="display: inline; width: 16px; height: 13px">
                                                        </div>
                                                        <asp:Button ID="btnDataBaseTypePrevPage" runat="server" Width="50px" 
                                                            Text="��һҳ"></asp:Button>
                                                        <asp:Button ID="btnDataBaseTypeNextPage" runat="server" Width="50px" 
                                                            Text="��һҳ"></asp:Button>����
                                                        <asp:TextBox ID="txtDataBaseTypeJump2Page" runat="server" Width="35px" ></asp:TextBox>ҳ
                                                        <asp:Button ID="btnDataBaseTypeJumpPage" runat="server" Width="35px" 
                                                            Text="ȷ��"></asp:Button>
                                                        <asp:CompareValidator ID="DataBaseTypeCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                            ErrorMessage="����" ControlToValidate="txtDataBaseTypeJump2Page" Type="Integer"
                                                            Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <table id="tabEditDataBaseTypeRegion" style="width: 736px" cellspacing="1" cellpadding="1"
                            width="736" border="4" bordercolor="#666666" runat="server">
                            <tr>
                                <td style="height: 34px">
                                    <div style="width: 714px; position: relative; height: 32px">
                                        <asp:Button ID="btnOKUpd" Style="z-index: 102; left: 488px; position: absolute; top: 8px"
                                            runat="server"   Text="���"></asp:Button>
                                        <asp:Label ID="lblMsg" Style="z-index: 101; left: 272px; position: absolute; top: 8px"
                                            runat="server" Width="208px" CssClass="text-warning"></asp:Label>
                                        <asp:Label ID="Label1" Style="z-index: 103; left: 8px; position: absolute; top: 8px"
                                            runat="server" CssClass="h6">�༭���ݿ���������</asp:Label>
                                        <asp:LinkButton ID="lbDispObjList" Style="z-index: 104; left: 592px; position: absolute;
                                            top: 8px" runat="server" Width="121px">��ʾ���ݿ������б�</asp:LinkButton>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <uc1:wucDataBaseType ID="wucDataBaseType1" runat="server"></uc1:wucDataBaseType>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
