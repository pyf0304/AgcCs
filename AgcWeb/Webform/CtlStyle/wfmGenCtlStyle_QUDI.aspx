<%@ Register TagPrefix="uc1" TagName="wucGenCtlStyle" Src="wucGenCtlStyle.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmGenCtlStyle_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmGenCtlStyle_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表GenCtlStyle的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
      
            <asp:Label ID="lblTitle" Style="z-index: 101; left: 200px; position: absolute; top: 20px"
                runat="server" Width="432px" Height="33px" Font-Names="黑体" Font-Size="Larger">GenCtlStyle表的查询、修改、删除、添加</asp:Label>
            <asp:Label ID="lblGenCtlStyleNameq" Style="z-index: 102; left: 200px; position: absolute;
                top: 60px" runat="server"  
                >模式名</asp:Label>
            <asp:TextBox ID="txtGenCtlStyleNameq" Style="z-index: 103; left: 300px; position: absolute;
                top: 60px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Label ID="lblRunatq" Style="z-index: 104; left: 200px; position: absolute;
                top: 88px" runat="server"  
                >运行在</asp:Label>
            <asp:TextBox ID="txtRunatq" Style="z-index: 105; left: 300px; position: absolute;
                top: 88px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 106; left: 452px; position: absolute; top: 116px"
                runat="server"  Text="查询"></asp:Button>
            <asp:DataGrid ID="dgGenCtlStyle" Style="z-index: 107; left: 67px; position: absolute;
                top: 156px" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
                PageSize="5" AllowPaging="True" Font-Names="宋体" >
                <Columns>
                    <asp:BoundColumn DataField="GenCtlStyleId" HeaderText="模式ID"></asp:BoundColumn>
                    <asp:BoundColumn DataField="GenCtlStyleName" HeaderText="模式名"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Runat" HeaderText="运行在"></asp:BoundColumn>
                    <asp:BoundColumn DataField="FontSize" HeaderText="字体大小"></asp:BoundColumn>
                    <asp:BoundColumn DataField="FontName" HeaderText="字体名"></asp:BoundColumn>
                    <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
                <PagerStyle Mode="NumericPages"></PagerStyle>
            </asp:DataGrid>
            <asp:Label ID="lblRecCount" Style="z-index: 108; left: 137px; position: absolute;
                top: 316px" runat="server" Width="110px"  >查询结果记录数：</asp:Label>
            <asp:TextBox ID="txtRecCount" Style="z-index: 109; left: 259px; position: absolute;
                top: 316px" runat="server" Width="111px" 
                ReadOnly="True"></asp:TextBox>
            <table id="tabLayout" style="z-index: 110; left: 65px; width: 373px; position: absolute;
                top: 341px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="1">
                <tr>
                    <td>
                        <uc1:wucGenCtlStyle id="wucGenCtlStyle1" runat="server">
                        </uc1:wucGenCtlStyle></td>
                </tr>
            </table>
            <asp:Button ID="btnOKUpd" Style="z-index: 111; left: 460px; position: absolute; top: 341px"
                runat="server"   Text="添加"></asp:Button>
            <asp:Label ID="lblMsg" Style="z-index: 112; left: 461px; position: absolute; top: 376px"
                runat="server" Width="215px" ></asp:Label>
       
    </form>
</body>
</html>
