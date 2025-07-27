<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucConstraintFields4DL.ascx.cs" Inherits="AGC.Webform.wucConstraintFields4DL" %>

<script type="text/javascript" src="../../JS/tzPubFun.js"></script>

<script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
<style type="text/css">
    body {
        /*font-size: 0.875rem;*/
    }
</style>

<div id="divList" class="div_List" runat="server" style="width: 100%">
     <div style="padding: 10px">
       
        <%--<span style="background-color: #c0c0c0; margin-left: 400px; margin-top: 10px;">约束名称:</span>
        <asp:Label ID="lblConstraintName" runat="server" CssClass="Label_DefaInPager" ></asp:Label>
        <span style="background-color: #c0c0c0; margin-left: 400px; margin-top: 10px;">约束类型:</span>
        <asp:Label ID="lblConstraintTypeName" runat="server" CssClass="Label_DefaInPager"></asp:Label>--%>
         <asp:Label ID="lblConstraintName" runat="server" CssClass="h6" >请为新约束选择字段:</asp:Label>
    </div>
    <div>
        <asp:DataList ID="dlConstraintFields" runat="server" DataKeyField="mId" OnItemDataBound="dlConstraintFields_ItemDataBound" OnItemCommand="dlConstraintFields_ItemCommand" OnSelectedIndexChanged="dlConstraintFields_SelectedIndexChanged" BorderStyle="None" >
            <HeaderTemplate>
                <table style="width: 1203px; border-bottom-color: brown; border-collapse:collapse; " id="tabT<%# DataBinder.Eval(Container.DataItem, "mId")%>" border="0" class="mt-4">
            </HeaderTemplate>
            
            <ItemStyle CssClass="border-0" />
            
            <ItemTemplate>
                <asp:Literal ID="litTR4FuncModule" runat="server"></asp:Literal>

                <tr style="border:1px" >
                       <td style="border:solid; border-width:1px; width: 60px; vertical-align: top; text-align:right" class="text-success mr-2">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("OrderNum")%>' CssClass="text-primary text-nowrap mr-1"></asp:Label>
                    </td>
                    <td style="border:solid; border-width:1px; width: 60px; vertical-align: top; text-align:right" class="text-success mr-2">
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("FldName")%>' CssClass="text-primary text-nowrap mr-1"></asp:Label>
                    </td>
                    <td id="td3" style="border:solid; border-width:1px; width: 800px;" class="ValueTD" runat="server">
                        <div>
                            <div class="float-left" style="width: 65%">
                                <asp:Literal ID="litTR" runat="server"></asp:Literal>
                            </div>
                            <div class="float-right" style="width: 35%; text-align:right">
                                <ul class="nav">
                                    <li class="nav-item ml-3">
                                        <div class="btn-group" role="group" aria-label="Basic example">
                                            <asp:Button ID="btnDelete" CommandArgument='<%# Eval("mId") %>' CommandName="Delete" runat="server"
                                                CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>

                                        <asp:Button ID="btnUpMove" CommandArgument='<%# Eval("mId") %>' CommandName="UpMove" runat="server" Text="上移" CssClass="btn btn-outline-info btn-sm ml-1" />
                                            <asp:Button ID="btnDownMove" CommandArgument='<%# Eval("mId") %>' CommandName="DownMove" runat="server" Text="下移" CssClass="btn btn-outline-info btn-sm ml-1" />
                                        </div>
                                    </li>
                                </ul>
                            </div>
                        </div>

                    </td>
                </tr>

                 <asp:Literal ID="litRelaRequirement" runat="server"></asp:Literal>

            </ItemTemplate>
       
            <EditItemStyle CssClass=" border-0" />
       
            <FooterTemplate>
                </table>
            </FooterTemplate>
         
        </asp:DataList>

    </div>
    <div style="padding: 10px">
        <ul class="nav">
            <li class="nav-item ml-3">
                <span style="background-color: #c0c0c0; margin-left: 400px; margin-top: 10px;">约束字段:</span>
            </li>
            <li class="nav-item ml-3">
                   <asp:DropDownList ID="ddlFldId" runat="server" class="form-control-sm"></asp:DropDownList>
            </li>
            <li class="nav-item ml-3">
                 <asp:Button ID="btnAdd" runat="server"
                                                CssClass="btn btn-outline-info btn-sm" Text="添加" OnClick="btnAdd_Click"></asp:Button>
                                 
            </li>
        </ul>
    </div>
    <table id="tabwucPrjConstraint" style="width: 600px; padding: 1px;" border="0">
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">约束表名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtConstraintName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr id="trHidden" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblTabId" runat="server" CssClass="col-form-label text-right">表ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblConstraintTypeId" runat="server" CssClass="col-form-label text-right">约束类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlConstraintTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblConstraintDescription" runat="server" CssClass="col-form-label text-right">约束说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtConstraintDescription" runat="server" class="form-control-sm" Height="129px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblInUse" runat="server" CssClass="col-form-label text-right">是否在用</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlInUse" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="46px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>

</div>

