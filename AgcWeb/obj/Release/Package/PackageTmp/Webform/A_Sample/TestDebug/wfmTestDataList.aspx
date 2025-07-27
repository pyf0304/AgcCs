<%@ Page Language="c#" CodeBehind="wfmTestDataList.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmTestDataList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>wfmTestDataList</title>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="Label1" Style="z-index: 101; left: 24px; position: absolute; top: 16px"
            runat="server" Height="40px" Width="184px">Label</asp:Label>
        <asp:Button ID="Button1" Style="z-index: 102; left: 272px; position: absolute; top: 0px"
            runat="server" Height="40px" Width="128px" Text="显示内容"></asp:Button>
        <asp:DataList ID="dlOptMemo" Style="z-index: 103; left: 40px; position: absolute;
            top: 64px" runat="server" Width="592px" DataKeyField="mid">
            <ItemTemplate>
                
                    <table id="Table2" style="width: 584px; height: 92px" cellspacing="1" cellpadding="1"
                        width="584" border="1">
                        <tr>
                            <td>
                                撰写者：
                                <%# DataBinder.Eval(Container.DataItem, "Author") %>
                            </td>
                            <td>
                                日期：<%# DataBinder.Eval(Container.DataItem, "Rq") %>
                            </td>
                            <td>
                                <asp:HyperLink ID="LinkButton1" NavigateUrl='<%# DataBinder.Eval(Container.DataItem, "Author") %>'
                                    Text='<%# DataBinder.Eval(Container.DataItem, "Author") %>' runat="server">
                                </asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: 12px; color: #0000cc; text-decoration: underline" colspan="2">
                                操作说明：</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div style="display: inline; width: 592px; height: 88px">
                                    <%# DataBinder.Eval(Container.DataItem, "Memo") %>
                                </div>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </font>
            </ItemTemplate>
        </asp:DataList>
        <asp:HyperLink ID="HyperLink1" Style="z-index: 104; left: 480px; position: absolute;
            top: 16px" runat="server" NavigateUrl="abc.html">HyperLink</asp:HyperLink>
    </form>
</body>
</html>
