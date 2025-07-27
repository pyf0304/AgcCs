<%@ Page Title="" Language="C#" MasterPageFile="~/Webform/Table2/EditTable.master"
    AutoEventWireup="True" CodeBehind="wfmGeneSP4MsSql_QUDI2.aspx.cs" Inherits="AGC.Webform.wfmGeneSP4MsSql_QUDI2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>生成表字段综合维护</title>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 648px">
        <tr>
            <td style="width: 183px">
                <asp:Label ID="Label12" runat="server" Style="left: 3px; top: 46px" Text="表名"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblTabName" runat="server" Text="表名" Width="495px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:CheckBox ID="chkStoreProcedure_Add" runat="server" Style="left: -6px; top: 66px"
                    Text="表存储过程--Add(添加)" />
            </td>
            <td>
                <asp:Label ID="lblMsg_Add" runat="server" CssClass="text-warning" Width="422px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:CheckBox ID="chkStoreProcedure_Update" runat="server" Text="表存储过程--Update(修改)" />
            </td>
            <td>
                <asp:Label ID="lblMsg_Update" runat="server" CssClass="text-warning" Width="424px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:CheckBox ID="chkStoreProcedure_Delete" runat="server" Text="表存储过程--Delete(删除)" />
            </td>
            <td>
                <asp:Label ID="lblMsg_Delete" runat="server" CssClass="text-warning" Width="422px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:CheckBox ID="chkStoreProcedure_Select" runat="server" Style="left: -451px; top: 63px"
                    Text="表存储过程--Select(查询)" />
            </td>
            <td>
                <asp:Label ID="lblMsg_Select" runat="server" CssClass="text-warning" Width="422px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:CheckBox ID="chkStoreProcedure_SelectOne" runat="server" Style="left: -55px;
                    top: 80px" Text="表存储过程--SelectOne(查询一条)" />
            </td>
            <td>
                <asp:Label ID="lblMsg_SelectOne" runat="server" CssClass="text-warning" Width="422px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:CheckBox ID="chkStoreProcedure_SelectByCond" runat="server" Style="left: -6px;
                    top: 47px" Text="表存储过程--SelectByCond(查询条件)" />
            </td>
            <td>
                <asp:Label ID="lblMsg_SelectByCond" runat="server" CssClass="text-warning" Width="422px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:CheckBox ID="chkStoreProcedure_IsExist" runat="server" Text="表存储过程--IsExist(查询条件)" />
            </td>
            <td>
                <asp:Label ID="lblMsg_IsExist" runat="server" CssClass="text-warning" Width="422px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:CheckBox ID="chkStoreProcedure_SelTop1ByCond" runat="server" Style="left: -114px;
                    top: 225px" Text="表存储过程--SelTop1ByCond(查询Top)" Width="250px" />
            </td>
            <td>
                <asp:Label ID="lblMsg_SelTop1ByCond" runat="server" CssClass="text-warning" Width="422px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 183px">
                <asp:Button ID="btnGeneStoreProcedure" runat="server" OnClick="btnGeneStoreProcedure_Click"
                    Text="生成存储过程" Width="112px" />
            </td>
            <td>
                <asp:Button ID="btnGeneSPXmlPara" runat="server" OnClick="btnGeneSPXmlPara_Click"
                    Text="生成存储过程XML参数" Width="154px" />
                <asp:Label ID="lblMsg4GeneStoreProcedure" runat="server" CssClass="text-warning" Width="276px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txtCode4StoreProcedure" runat="server" Height="270px" TextMode="MultiLine"
                    Width="677px"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
