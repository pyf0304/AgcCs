<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFeatureRegionFldsB.ascx.cs" Inherits="AGC.Webform.wucFeatureRegionFldsB" %>
<link href="../../Content/bootstrap.css" rel="stylesheet" />
<table id="tabwucFeatureRegionFlds" style="width: 400px; padding: 2px; border-spacing: 2px;" border="0">
    <tr id="trHidden2" runat="server">
        <td class="text-right">
            <asp:Label ID="lblRegionId" runat="server" CssClass="col-form-label text-right">区域</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtRegionId" runat="server" Width="300px" class="form-control-sm"></asp:TextBox>
            <asp:CompareValidator ID="ComValid_RegionId" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtRegionId"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>

    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblFeatureId" runat="server" CssClass="col-form-label text-right">功能</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFeatureId" runat="server" Width="200Px" class="form-control-sm" OnSelectedIndexChanged="ddlFeatureId_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:CheckBox ID="chkInUse" runat="server" Text="是否在用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
    </tr>
      <tr id="trKeyIdGetModeId" runat="server">
        <td class="text-right">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">关键字方式</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlKeyIdGetModeId" runat="server" Width="300px" class="form-control-sm" ></asp:DropDownList>
            
        </td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblCtlTypeId" runat="server" CssClass="col-form-label text-right">控件类型</asp:Label>
        </td>
        <td class="ValueTD">
            <table>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlCtlTypeId" runat="server" Width="120Px" class="form-control-sm"></asp:DropDownList>
                    </td>
                    <td class="text-right">
                        <asp:Label ID="lblSeqNum" Width="50px" runat="server" CssClass="col-form-label text-right">序号</asp:Label>
                    </td>
                    <td class="ValueTD">
                        <asp:TextBox ID="txtSeqNum" runat="server" Width="120Px" class="form-control-sm"></asp:TextBox>
                        <asp:CompareValidator ID="ComValid_SeqNum" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtSeqNum"
                            Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
                        </asp:CompareValidator>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr id="trButtonName" runat="server">
        <td class="text-right">
            <asp:Label ID="lblButtonName" runat="server" CssClass="col-form-label text-right">按钮名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtButtonName" runat="server" Width="300px" class="form-control-sm"></asp:TextBox>
        </td>
    </tr>
    <tr id="trButtonName4Mvc" runat="server">
        <td class="text-right">
            <asp:Label ID="lblButtonName4Mvc" runat="server" CssClass="col-form-label text-right">名称4Mvc</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtButtonName4Mvc" runat="server" Width="300px" class="form-control-sm"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblText" runat="server" CssClass="col-form-label text-right">文本</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtText" runat="server" Width="300px" class="form-control-sm"></asp:TextBox>
        </td>
    </tr>
      <tr id="trHidden4" runat="server">
        <td class="text-right">
            <asp:Label ID="lblCssClass" runat="server" CssClass="col-form-label text-right">样式表</asp:Label>
        </td>
        <td class="ValueTD">
            <table>

                <tr id="trHidden5" runat="server">
                    <td>
                        <asp:TextBox ID="txtCssClass" runat="server" Width="120Px" class="form-control-sm"></asp:TextBox>
                    </td>
                    <td class="text-right">
                        <asp:Label ID="lblWidth" runat="server" CssClass="col-form-label text-right">宽</asp:Label>
                    </td>
                    <td class="ValueTD">
                        <asp:TextBox ID="txtWidth" runat="server" Width="120Px" class="form-control-sm"></asp:TextBox>
                        <asp:CompareValidator ID="ComValid_Width" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtWidth"
                            Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
                        </asp:CompareValidator>
                    </td>

                </tr>

            </table>
        </td>

    </tr>

    <tr>
        <td class="text-right">
            <asp:Label ID="lblViewImplId" runat="server" CssClass="col-form-label text-right">实现区域</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlViewImplId" runat="server" Width="300px" class="form-control-sm"></asp:DropDownList>
        </td>

    </tr>
     <tr id="trGroupName" runat="server">
        <td class="text-right">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">组名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtGroupName" runat="server" Width="300px" class="form-control-sm"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblTabFeatureId" CssClass="col-form-label text-right" Width="90px" Text="表功能" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabFeatureId" CssClass="form-control" Width="300px" runat="server" />
        </td>

    </tr>


    <tr id="trHidden" runat="server">
        <td class="text-right">
            <asp:Label ID="lblTabId" runat="server" CssClass="col-form-label text-right">表</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabId" runat="server" Width="300px" class="form-control-sm" AutoPostBack="True"></asp:DropDownList>
        </td>
    </tr>
    <tr id="trFieldTypeId" runat="server">
        <td class="text-right">
            <asp:Label ID="lblFieldTypeId" CssClass="text-secondary" Width="90px" Text="字段类型" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFieldTypeId" Width="300px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFieldTypeId_SelectedIndexChanged" />
        </td>

    </tr>
    <tr id="trFldId" runat="server">
        <td class="text-right">
            <asp:Label ID="lblFldId" runat="server" CssClass="col-form-label text-right">字段</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFldId" runat="server" Width="300px" class="form-control-sm" AutoPostBack="True" OnSelectedIndexChanged="ddlFldId_SelectedIndexChanged"></asp:DropDownList>
        </td>
    </tr>

    <tr id="trValueGivingModeId" runat="server">
        <td class="text-right">
            <asp:Label ID="lblValueGivingModeId" CssClass="text-secondary" Width="90px" Text="给值方式" runat="server" />
        </td>
        <td class="ValueTD">
            <table>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlValueGivingModeId" Width="110Px" runat="server" />

                    </td>
                    <td class="text-right">
                        <asp:Label ID="lblDefaultValue" CssClass="text-secondary" Width="70px" Text="缺省值" runat="server" />
                    </td>
                    <td class="ValueTD">
                        <asp:TextBox ID="txtDefaultValue" class="ValueControl" Width="110Px" runat="server" />
                    </td>

                </tr>
            </table>
        </td>

    </tr>

     <tr id="trEventFuncName" runat="server">
        <td class="text-right">
            <asp:Label ID="Label2" CssClass="text-secondary" Width="90px" Text="事件函数" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtEventFuncName" class="ValueControl" Width="300px" runat="server" />
        </td>

    </tr>
    <tr id="trFuncName" runat="server">
        <td class="text-right">
            <asp:Label ID="lblFuncName" CssClass="text-secondary" Width="90px" Text="调用函数" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncName" class="ValueControl" Width="300px" runat="server" />
        </td>

    </tr>






    <%--    <tr>
        <td class="text-right">
            <asp:Label ID="lblFeatureDescription" runat="server" CssClass="col-form-label text-right">功能说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFeatureDescription" runat="server" Width="300px" class="form-control-sm" Height="36px" TextMode="MultiLine"></asp:TextBox>
        </td>

    </tr>--%>
    <tr id="trHidden3" runat="server">
        <td class="text-right">
            <asp:Label ID="lblImageUrl" runat="server" CssClass="col-form-label text-right">图片资源</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtImageUrl" runat="server" Width="300px" class="form-control-sm"></asp:TextBox>
        </td>

    </tr>

  
    <%--  <tr id="trHidden6" runat="server">
        <td class="text-right">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Width="300px"></asp:TextBox>
        </td>

    </tr>--%>
</table>
