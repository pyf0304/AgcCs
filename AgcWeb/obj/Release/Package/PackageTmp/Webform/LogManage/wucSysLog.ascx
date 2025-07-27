<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucSysLog.ascx.cs" Inherits="AGC.wucSysLog"
    %>
<table id="tabwucSysLog" cellspacing="1" cellpadding="1" width="304" border="0" style="width: 304px;
    height: 242px">
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblUserId" runat="server" >用户编号</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblUserName" runat="server" >用户姓名</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtUserName" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblUserIp" runat="server" >用户IP</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtUserIp" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblOpDate" runat="server" >操作日期</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtOpDate" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblOpTime" runat="server" >操作时间</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtOpTime" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblOpType" runat="server" >操作类型</asp:Label></p>
        </td>
        <td>
            <asp:DropDownList ID="ddlOpTypeId" runat="server" 
                Width="158px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblTableName" runat="server" >数据表名</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtTableName" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblTableKey" runat="server" >数据表关键字段名</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtTableKey" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <p align="right">
                <asp:Label ID="lblOpContent" runat="server" >操作内容</asp:Label></p>
        </td>
        <td>
            <asp:TextBox ID="txtOpContent" runat="server" ></asp:TextBox>
        </td>
    </tr>
</table>
