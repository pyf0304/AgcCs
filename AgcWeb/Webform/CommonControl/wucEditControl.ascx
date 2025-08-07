<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucEditControl.ascx.cs"
    Inherits="AGC.Webform.wucEditControl" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<table id="tabwucEditRegionFlds" border="0" style="width: 400px;">

    <tr>
        <td class="text-right" style="width: 100px;">
            <asp:Label ID="lblCtlTypeId" runat="server" CssClass="col-form-label-sm">控件类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCtlTypeId" runat="server" CssClass="form-control-sm" Width="300px" OnSelectedIndexChanged="ddlCtlTypeId_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
        </td>
    </tr>
    <tr id="trDdlItemsOptionId" runat="server">
        <td class="text-right">
            <asp:Label ID="lblDdlItemsOptionId" runat="server" CssClass="col-form-label-sm">下拉列表</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDdlItemsOptionId" runat="server" CssClass="form-control-sm" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="ddlDdlItemsOptionId_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
     <tr id="trCallTabFeatureId" runat="server">
        <td class="text-right">
            <asp:Label ID="Label6" runat="server" CssClass="col-form-label-sm">调用功能</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCallTabFeatureId" runat="server" CssClass="form-control-sm" Width="300px" >
            </asp:DropDownList>
        </td>
    </tr>
    <tr id="trVar" runat="server">
        <td class="text-right">
            <asp:Label ID="Label4" runat="server" CssClass="col-form-label-sm">界面变量</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlVarId" runat="server" CssClass="form-control-sm" Width="300px">
            </asp:DropDownList>
        </td>
    </tr>
      <tr id="trDefaValue" runat="server">
        <td class="text-right">
            <asp:Label ID="Label5" runat="server" CssClass="col-form-label-sm">缺省值</asp:Label>
        </td>
        <td>
        <asp:TextBox ID="txtDefaultValue" runat="server" CssClass="form-control-sm" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr id="trDsTabId" runat="server">
        <td class="text-right">
            <asp:Label ID="lblDsTabId" runat="server" CssClass="col-form-label-sm text-nowrap">数据源</asp:Label>
        </td>
        <td>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" Width="50px" runat="server" CssClass="col-form-label-sm text-nowrap">表</asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlDsTabId" runat="server" CssClass="form-control-sm"
                            Width="250px" AutoPostBack="True" OnSelectedIndexChanged="ddlDsTabId_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDsDataValueFieldId" runat="server" CssClass="col-form-label-sm text-nowrap">值</asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlDsDataValueFieldId" runat="server" CssClass="form-control-sm" Width="250px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDsDataTextFieldId" runat="server" CssClass="col-form-label-sm text-nowrap">文本</asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlDsDataTextFieldId" runat="server" CssClass="form-control-sm" Width="250px">
                        </asp:DropDownList>
                    </td>
                </tr>
                   <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" CssClass="col-form-label-sm text-nowrap">条件</asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlDs_CondFieldId" runat="server" CssClass="form-control-sm" Width="250px">
                        </asp:DropDownList>
                    </td>
                </tr>
                   <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" CssClass="col-form-label-sm text-nowrap">排序</asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlDs_SortFieldId" runat="server" CssClass="form-control-sm" Width="250px">
                        </asp:DropDownList>
                    </td>
                </tr>

            </table>
        </td>

    </tr>
    <tr id="trDsCondStr" runat="server">
        <td class="text-right">
            <asp:Label ID="lblDsCondStr" Width="90px" runat="server" CssClass="col-form-label-sm">数据源条件</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDsCondStr" runat="server" CssClass="form-control-sm"
                Width="300px" Height="55px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr id="trDsSqlStr" runat="server">
        <td class="text-right">
            <asp:Label ID="lblDsSqlStr" runat="server" CssClass="col-form-label-sm">SQL串</asp:Label></td>
        <td>
            <asp:TextBox ID="txtDsSqlStr" runat="server" CssClass="form-control-sm"
                Width="300px" Height="55px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr id="trItemsString" runat="server">
        <td class="text-right">
            <asp:Label ID="lblItemsString" runat="server" CssClass="col-form-label-sm">列表项串</asp:Label></td>
        <td>
            <asp:TextBox ID="txtItemsString" runat="server" CssClass="form-control-sm"
                Width="300px" Height="55px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
</table>

