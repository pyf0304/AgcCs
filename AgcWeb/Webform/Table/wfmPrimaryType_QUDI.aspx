<%@ Register TagPrefix="uc1" TagName="wucPrimaryType" Src="wucPrimaryType.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmPrimaryType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrimaryType_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表PrimaryTypeName的查询、修改、删除、添加记录</title>
    
      <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
 
            <asp:Label ID="Label3" Style="z-index: 115; left: 8px; position: absolute; top: 8px"
                runat="server" Font-Size="Larger" Font-Names="黑体" Width="240px"
                ForeColor="Blue">表字段管理->关键字类型维护</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 103; left: 248px; position: absolute; top: 8px"
                runat="server"  Width="42px"
                ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
            <asp:Label ID="Label1" Style="z-index: 101; left: 288px; position: absolute; top: 8px"
                runat="server"  Height="32px" Width="368px"
                ForeColor="#004040">主要用来维护表字段的关键字类型。</asp:Label>
            <asp:Label ID="lblPrimaryTypeIdq" Style="z-index: 102; left: 16px; position: absolute;
                top: 48px" runat="server" Width="94px" >关键字类型号</asp:Label>
            <asp:TextBox ID="txtPrimaryTypeIdq" Style="z-index: 105; left: 128px; position: absolute;
                top: 48px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Label ID="lblPrimaryTypeNameq" Style="z-index: 106; left: 16px; position: absolute;
                top: 72px" runat="server" Width="94px" >关键字类型名称</asp:Label>
            <asp:TextBox ID="txtPrimaryTypeNameq" Style="z-index: 107; left: 128px; position: absolute;
                top: 72px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 108; left: 248px; position: absolute; top: 72px"
                runat="server"  Text="查询"></asp:Button>
            <asp:DataGrid ID="dgPrimaryType" Style="z-index: 109; left: 8px; position: absolute;
                top: 112px" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
                PageSize="5" AllowPaging="True" Font-Names="宋体" Font-Size="Smaller">
                <Columns>
                    <asp:BoundColumn DataField="PrimaryTypeId" HeaderText="关键字类型号">
                        <HeaderStyle ></HeaderStyle>
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="PrimaryTypeName" HeaderText="关键字类型名称">
                        <HeaderStyle Width="100px"></HeaderStyle>
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="Memo" HeaderText="说明">
                        <HeaderStyle Width="230px"></HeaderStyle>
                    </asp:BoundColumn>
                    <asp:ButtonColumn Text="修改" HeaderText="功能" CommandName="Update">
                        <HeaderStyle Width="30px"></HeaderStyle>
                    </asp:ButtonColumn>
                    <asp:TemplateColumn HeaderText="功能">
                        <HeaderStyle Width="30px"></HeaderStyle>
                        <ItemTemplate>
                            <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
                <PagerStyle Mode="NumericPages"></PagerStyle>
            </asp:DataGrid>
            <asp:Label ID="lblRecCount" Style="z-index: 110; left: 8px; position: absolute; top: 280px"
                runat="server" Width="110px"  Font-Names="宋体" Font-Size="Smaller">查询结果记录数：</asp:Label>
            <asp:TextBox ID="txtRecCount" Style="z-index: 111; left: 120px; position: absolute;
                top: 272px" runat="server" Width="96px"  Font-Names="宋体" Font-Size="Smaller"
                ReadOnly="True"></asp:TextBox>
            <table id="tabLayout" style="z-index: 112; left: 8px; width: 373px; position: absolute;
                top: 304px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="1">
                <tr>
                    <td>
                        <uc1:wucPrimaryType id="wucPrimaryType1" runat="server">
                        </uc1:wucPrimaryType></td>
                </tr>
            </table>
            <asp:Button ID="btnOKUpd" Style="z-index: 113; left: 400px; position: absolute; top: 320px"
                runat="server"   Text="添加"></asp:Button>
            <asp:Label ID="lblMsg" Style="z-index: 114; left: 400px; position: absolute; top: 352px"
                runat="server" Width="104px" ></asp:Label>
    
    </form>
</body>
</html>
