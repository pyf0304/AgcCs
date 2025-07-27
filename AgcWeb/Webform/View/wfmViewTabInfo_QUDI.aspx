<%@ Register TagPrefix="uc1" TagName="wucViewTabInfo" Src="wucViewTabInfo.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmViewTabInfo_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewTabInfo_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表ViewTabInfo的查询、修改、删除、添加记录</title>
      <script type="text/javascript" src="../../Scripts/jquery-3.4.1.min.js"></script>
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
        
            <asp:Label ID="lblTitle" Style="z-index: 101; left: 200px; position: absolute; top: 20px"
                runat="server" Width="432px" Height="33px" Font-Names="黑体" Font-Size="Larger">ViewTabInfo表的查询、修改、删除、添加</asp:Label>
            <asp:Label ID="lblViewId_q" Style="z-index: 103; left: 200px; position: absolute;
                top: 85px" runat="server" Width="100px" >界面ID</asp:Label>
            <asp:DropDownList ID="ddlViewId_q" Style="z-index: 104; left: 300px; position: absolute;
                top: 85px" runat="server" Width="128px" >
            </asp:DropDownList>
            <asp:Label ID="lblDataBaseName_q" Style="z-index: 105; left: 200px; position: absolute;
                top: 110px" runat="server" Width="100px" >数据库名</asp:Label>
            <asp:TextBox ID="txtDataBaseName_q" Style="z-index: 106; left: 300px; position: absolute;
                top: 110px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Label ID="lblTabName_q" Style="z-index: 107; left: 200px; position: absolute;
                top: 135px" runat="server" Width="100px" >表名</asp:Label>
            <asp:TextBox ID="txtTabName_q" Style="z-index: 108; left: 300px; position: absolute;
                top: 135px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 109; left: 452px; position: absolute; top: 160px"
                runat="server" Width="78px" Height="28px" Text="查询"></asp:Button>
            <asp:DataGrid ID="dgViewTabInfo" Style="z-index: 110; left: 67px; position: absolute;
                top: 200px" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
                PageSize="5" AllowPaging="True" Font-Names="宋体" >
                <Columns>
                    <asp:BoundColumn DataField="MId" HeaderText="递增ID"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ViewId" HeaderText="界面ID"></asp:BoundColumn>
                    <asp:BoundColumn DataField="DataBaseName" HeaderText="数据库名"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TabName" HeaderText="表名"></asp:BoundColumn>
                    <asp:HyperLinkColumn Text="操作流程" HeaderText="操作流程" NavigateUrl='wfmViewOptSteps.aspx?ViewId=<% #Container.DataItem("ViewId") %>'>
                    </asp:HyperLinkColumn>
                    <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
                <PagerStyle Mode="NumericPages"></PagerStyle>
            </asp:DataGrid>
            <asp:Label ID="lblRecCount" Style="z-index: 111; left: 137px; position: absolute;
                top: 360px" runat="server" Width="110px"  Font-Names="宋体" >查询结果记录数：</asp:Label>
            <asp:TextBox ID="txtRecCount" Style="z-index: 112; left: 259px; position: absolute;
                top: 360px" runat="server" Width="111px"  Font-Names="宋体" 
                ReadOnly="True"></asp:TextBox>
            <table id="tabLayout" style="z-index: 113; left: 65px; width: 373px; position: absolute;
                top: 385px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="1">
                <tr>
                    <td>
                        <uc1:wucViewTabInfo id="wucViewTabInfo1" runat="server">
                        </uc1:wucViewTabInfo></td>
                </tr>
            </table>
            <asp:Button ID="btnOKUpd" Style="z-index: 114; left: 460px; position: absolute; top: 385px"
                runat="server" Width="83px" Height="31px" Text="添加"></asp:Button>
            <asp:Label ID="lblMsg" Style="z-index: 115; left: 461px; position: absolute; top: 420px"
                runat="server" Width="215px" Height="27px"></asp:Label>
        </font>
    </form>
</body>
</html>
