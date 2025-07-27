<%@ Page Language="c#" CodeBehind="wfmSelectProject.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmSelectProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>选择工程与角色</title>
    <style type="text/css">
        A {
            COLOR: #000000;
            FONT-FAMILY: "宋体";
            TEXT-DECORATION: none
        }

            A:hover {
                COLOR: #336600;
                FONT-STYLE: normal;
                FONT-FAMILY: "宋体";
                TEXT-DECORATION: underline
            }

        .content {
            FONT-SIZE: 12px;
            COLOR: #2d2d2d;
            LINE-height: 17px;
            FONT-FAMILY: "verdana";
            TEXT-DECORATION: none
        }

        .content2 {
            FONT-SIZE: 14px;
            COLOR: #2d2d2d;
            FONT-FAMILY: "verdana";
            TEXT-DECORATION: none
        }

        .title {
            FONT-SIZE: 28px;
            COLOR: #2d2d2d;
            FONT-FAMILY: "黑体";
            TEXT-DECORATION: none
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <img style="z-index: 101; left: 8px; position: absolute; top: 24px" src="../pic/bar1.JPG" alt="" />
        <div style="display: inline; z-index: 102; left: 8px; width: 304px; position: absolute; top: 8px; height: 8px"
            class="content">
            当前位置：&nbsp;系统登录 &gt;&gt;&nbsp; <strong>帐号工程选择</strong>

        </div>
        <img style="z-index: 103; left: 24px; position: absolute; top: 88px" src="../pic/oragnebar.gif" alt="" />
        <div style="display: inline; z-index: 104; left: 224px; width: 384px; position: absolute; top: 56px; height: 16px"
            class="title">
            请选择一个工程使用系统
        </div>
        <asp:DataGrid ID="dgUserPrjGrant" Style="z-index: 105; left: 80px; position: absolute; top: 96px"
            runat="server" Width="720px" AutoGenerateColumns="False" CellSpacing="2"
            CellPadding="2" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC"
            CssClass="content2" OnSelectedIndexChanged="dgUserPrjGrant_SelectedIndexChanged">
            <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
            <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
            <ItemStyle ForeColor="#000066"></ItemStyle>
            <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
            <Columns>
                <asp:BoundColumn Visible="False" DataField="mId" HeaderText="编号"></asp:BoundColumn>
                <asp:BoundColumn DataField="UserId" HeaderText="帐号"></asp:BoundColumn>
                <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundColumn>
                <asp:BoundColumn Visible="False" DataField="RoleId" HeaderText="角色号"></asp:BoundColumn>
                <asp:BoundColumn DataField="PrjId" SortExpression="PrjId" HeaderText="项目Id"></asp:BoundColumn>
                <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="项目名称"></asp:BoundColumn>
                <asp:BoundColumn DataField="RoleName" SortExpression="RoleName" HeaderText="角色"></asp:BoundColumn>
                <asp:BoundColumn DataField="LastVisitedDate" SortExpression="LastVisitedDate" HeaderText="最后访问时间"></asp:BoundColumn>
                <asp:BoundColumn DataField="VisitedNum" SortExpression="VisitedNum" HeaderText="访问数"></asp:BoundColumn>
                <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                <asp:ButtonColumn Text="选择" CommandName="Select"></asp:ButtonColumn>
            </Columns>
            <PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
        </asp:DataGrid>
    </form>
</body>
</html>
