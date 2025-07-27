<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucwf_Process.ascx.cs" Inherits="AGC.Webform.wucwf_Process" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucwf_Process" name="tabwucwf_Process" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProcessId" name="lblProcessId" CssClass="col-form-label text-right" Width="90px" Text="过程ID" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtProcessId" name="txtProcessId" CssClass="form-control" Width="400px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProcessName" name="lblProcessName" CssClass="col-form-label text-right" Width="90px" Text="过程名称" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtProcessName" name="txtProcessName" CssClass="form-control" Width="400px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblStartPoint" name="lblStartPoint" CssClass="col-form-label text-right" Width="90px" Text="起点" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlStartPoint" name="ddlStartPoint" CssClass="form-control" Width="400px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblEndPoint" name="lblEndPoint" CssClass="col-form-label text-right" Width="90px" Text="终点" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlEndPoint" name="ddlEndPoint" CssClass="form-control" Width="400px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" name="lblOrderNum" CssClass="col-form-label text-right" Width="90px" Text="序号" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" name="txtOrderNum" CssClass="form-control" Width="400px" runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_OrderNum" name="ComValid_OrderNum" runat="server" CssClass="ErrMsg"
                ErrorMessage="请输入整型数值!"
                ControlToValidate="txtOrderNum"
                Type="Integer"
                Operator="DataTypeCheck"
                EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control" Width="400px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
