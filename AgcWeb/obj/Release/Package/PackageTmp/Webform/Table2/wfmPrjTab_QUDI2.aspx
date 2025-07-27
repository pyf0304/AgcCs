<%@ Page Title="" Language="C#" MasterPageFile="~/Webform/Table2/EditTable.master"
    AutoEventWireup="True" CodeBehind="wfmPrjTab_QUDI2.aspx.cs" Inherits="AGC.Webform.wfmPrjTab_QUDI2" %>

<%@ Register TagPrefix="uc3" TagName="wucPrjTab" Src="../Table/wucPrjTab.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>表字段综合维护</title>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <table id="tabEditPrjTabRegion" runat="server" border="1" cellpadding="1" cellspacing="1"
        style="z-index: 120; width: 750px" width="750">
        <tr>
            <td>
                <div style="width: 730px; position: relative; height: 32px">
                    <asp:Label ID="lblEditPrjTab" runat="server" CssClass="h6"
                        Style="z-index: 104; left: 0px; position: relative; top: 4px">工程表编辑区域</asp:Label>
                    <asp:Label ID="lblMsgEdit" runat="server" CssClass="text-warning" Style="z-index: 105;
                        left: 54px; position: relative; top: 8px" Width="208px"></asp:Label>
                    <asp:Button ID="btnOKUpd4Tab" runat="server" CssClass="btn btn-outline-info btn-sm" Style="z-index: 106;
                        left: 68px; position: relative; top: 4px" Text="添加"  OnClick="btnOKUpd4Tab_Click" />
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <uc3:wucPrjTab ID="wucPrjTab1" runat="server"></uc3:wucPrjTab>
            </td>
        </tr>
    </table>
</asp:Content>
