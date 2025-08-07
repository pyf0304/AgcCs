<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="wfmGeneStoreProcedure.aspx.cs" Inherits="Webform_Table_wfmGeneStoreProcedure" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>生成存储过程</title>
    
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
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 22px; position: absolute; top: 48px"
                Text="表名"></asp:Label>
            <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">表字段管理->项目表维护->生成存储过程                    </asp:Label>
            <asp:Label ID="lblTabName" runat="server" Style="z-index: 101; left: 64px; position: absolute; top: 48px"
                Text="表名" Width="495px"></asp:Label>
            <asp:CheckBox ID="chkStoreProcedure_Add" runat="server" Style="z-index: 102; left: 22px; position: absolute; top: 72px"
                Text="表存储过程--Add(添加)" />
            <asp:CheckBox ID="chkStoreProcedure_Update" runat="server" Style="z-index: 103; left: 22px; position: absolute; top: 102px"
                Text="表存储过程--Update(修改)" />
            <asp:CheckBox ID="chkStoreProcedure_Delete" runat="server" Style="z-index: 104; left: 22px; position: absolute; top: 132px"
                Text="表存储过程--Delete(删除)" />
            <asp:Button ID="btnGeneStoreProcedure" runat="server" OnClick="btnGeneStoreProcedure_Click"
                Style="z-index: 105; left: 27px; position: absolute; top: 297px" Text="生成存储过程"
                Width="112px" />
            <asp:Label ID="lblMsg_Add" runat="server" CssClass="text-warning" Style="z-index: 106; left: 260px; position: absolute; top: 75px"
                Width="422px"></asp:Label>
            <asp:Label ID="lblMsg_Delete" runat="server" CssClass="text-warning" Style="z-index: 107; left: 261px; position: absolute; top: 134px"
                Width="422px"></asp:Label>
            <asp:Label ID="lblMsg_Update" runat="server" CssClass="text-warning" Style="z-index: 108; left: 259px; position: absolute; top: 104px"
                Width="424px"></asp:Label>
            <asp:Label ID="LblMsg" runat="server" CssClass="text-warning" Style="z-index: 109; left: 324px; position: absolute; top: 300px"
                Width="276px"></asp:Label>
            <asp:Literal ID="litCode" runat="server"></asp:Literal>

            <asp:Button ID="btnGeneSPXmlPara" runat="server" OnClick="btnGeneSPXmlPara_Click"
                Style="z-index: 105; left: 143px; position: absolute; top: 297px" Text="生成存储过程XML参数"
                Width="154px" />
            <asp:CheckBox ID="chkStoreProcedure_Select" runat="server" Style="z-index: 104; left: 22px; position: absolute; top: 161px"
                Text="表存储过程--Select(查询)" />
            <asp:Label ID="lblMsg_Select" runat="server" CssClass="text-warning" Style="z-index: 107; left: 261px; position: absolute; top: 164px"
                Width="422px"></asp:Label>
            <asp:CheckBox ID="chkStoreProcedure_SelectOne" runat="server" Style="z-index: 104; left: 22px; position: absolute; top: 188px"
                Text="表存储过程--SelectOne(查询一条)" />
            <asp:CheckBox ID="chkStoreProcedure_SelectByCond" runat="server" Style="z-index: 104; left: 22px; position: absolute; top: 213px"
                Text="表存储过程--SelectByCond(查询条件)" />
            <asp:Label ID="lblMsg_SelectByCond" runat="server" CssClass="text-warning" Style="z-index: 107; left: 261px; position: absolute; top: 216px"
                Width="422px"></asp:Label>
            <asp:Label ID="lblMsg_SelectOne" runat="server" CssClass="text-warning" Style="z-index: 107; left: 261px; position: absolute; top: 191px"
                Width="422px"></asp:Label>
            <asp:CheckBox ID="chkStoreProcedure_IsExist" runat="server" Style="z-index: 104; left: 22px; position: absolute; top: 265px"
                Text="表存储过程--IsExist(查询条件)" />
            <asp:Label ID="lblMsg_IsExist" runat="server" CssClass="text-warning" Style="z-index: 107; left: 261px; position: absolute; top: 268px"
                Width="422px"></asp:Label>
            <asp:CheckBox ID="chkStoreProcedure_SelTop1ByCond" runat="server" Style="z-index: 104; left: 22px; position: absolute; top: 240px"
                Text="表存储过程--SelTop1ByCond(查询Top)" />
            <asp:Label ID="lblMsg_SelTop1ByCond" runat="server" CssClass="text-warning" Style="z-index: 107; left: 261px; position: absolute; top: 243px"
                Width="422px"></asp:Label>

        </div>
    </form>
</body>
</html>
