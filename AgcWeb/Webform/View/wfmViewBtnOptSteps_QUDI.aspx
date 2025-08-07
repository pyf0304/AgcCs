<%@ Register TagPrefix="uc1" TagName="wucViewBtnOptSteps" Src="wucViewBtnOptSteps.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmViewBtnOptSteps_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewBtnOptSteps_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表ViewBtnOptSteps的查询、修改、删除、添加记录</title>
    

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
        <table id="tabLayout" style="z-index: 108; left: 2px; width: 348px; position: absolute;
            top: 2px">
            <tr>
                <td style="width: 53px">
                    <div id="divHead" style="width: 419px; position: relative; height: 39px; left: 0px;
                        top: 0px;">
                        <asp:Label ID="Label3" Style="z-index: 100; left: 4px; position: absolute; top: 4px"
                            runat="server" Width="240px" CssClass="h5">项目界面管理->按钮操作步骤</asp:Label>
                        <asp:LinkButton ID="lbReturn" Style="z-index: 101; left: 786px; position: absolute;
                            top: 13px" runat="server" Width="32px" OnClick="lbReturn_Click">返回</asp:LinkButton>
                        <asp:Label ID="Label2" Style="z-index: 102; left: 258px; position: absolute; top: 6px"
                            runat="server" Width="42px" Font-Bold="True" CssClass="MemoStyleH5">说明：</asp:Label>
                        <asp:Label ID="Label4" Style="z-index: 103; left: 313px; position: absolute; top: 6px"
                            runat="server" Height="32px" Width="464px" CssClass="MemoStyle1">主要维护在界面设计过程中，界面按钮的详细操作，以此来帮助程序设计人员来为该界面设计代码。</asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td style="width: 53px">
        <table id="Table1" style="width: 456px; height: 241px" bordercolor="#330033" cellspacing="1" cellpadding="1"
            width="456" border="4">
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblViewIdq" runat="server"   CssClass="h6">界面ID</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlViewIdq" runat="server" Width="128px" >
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:DataGrid ID="dgViewBtnOptSteps" runat="server" Width="652px" Height="154px"
                        AutoGenerateColumns="False" AllowPaging="True" Font-Names="宋体" BorderColor="White"
                        BorderStyle="Ridge" BorderWidth="2px" CellSpacing="1" BackColor="White" CellPadding="3"
                        GridLines="None" CssClass="table table-striped table-bordered table-condensed">
                        <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                        <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="MId" HeaderText="递增ID"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="ViewId" HeaderText="界面ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="BtnName" HeaderText="按钮名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="BtnOptFunction" HeaderText="按钮操作功能"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="BtnStepDetail" HeaderText="按钮流程详细说明"></asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages">
                        </PagerStyle>
                    </asp:DataGrid></td>
            </tr>
            <tr>
                <td colspan="2" rowspan="1">
                    <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                        CssClass="text-secondary">查询结果记录数：</asp:Label></td>
                <td colspan="2" rowspan="1">
                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                        ReadOnly="True"></asp:TextBox></td>
            </tr>
        </table>
                </td>
            </tr>
            <tr>
                <td style="width: 53px">
                </td>
            </tr>
            <tr>
                <td style="width: 53px">
        <table id="tabEditRegion" style="width: 667px; height: 200px" cellspacing="1" cellpadding="1" border="4"
            bordercolor="#666666">
            <tr>
                <td valign="top" style="width: 397px">
                    <asp:Button ID="btnOKUpd" runat="server"   Text="添加" OnClick="btnOKUpd_Click">
                    </asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="215px" CssClass="text-warning"></asp:Label></td>
            </tr>
            <tr>
                <td valign="top" style="width: 397px">
                    <uc1:wucViewBtnOptSteps ID="wucViewBtnOptSteps1" runat="server"></uc1:wucViewBtnOptSteps>
                </td>
            </tr>
        </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
