<%@ Register TagPrefix="uc1" TagName="wucViewInfo" Src="wucViewInfo.ascx" %>

<%@ Page Title="表ViewInfo的查询、修改、删除、添加记录" Language="C#" MasterPageFile="~/Webform/MasterPage/mpViewEdit.Master" 
    AutoEventWireup="true" CodeBehind="wfmViewInfo_U.aspx.cs" Inherits="AGC.Webform.wfmViewInfo_U" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
      <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
    </asp:ScriptManager>
    <table id="tabLayout" style="width: 592px; height: 200px" bordercolor="#666666" cellspacing="1"
        cellpadding="1" width="592" border="1" runat="server">
        <tr>
            <td valign="top">
                <div style="width: 808px; position: relative; height: 28px">
                    <img style="z-index: 101; left: 0px; width: 776px; position: absolute; top: 0px;
                        height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776"/>
                    <asp:Label ID="Label5" Style="z-index: 102; left: 0px; position: absolute; top: 8px"
                        runat="server" CssClass="h6">编辑界面属性</asp:Label>
                    <asp:Button ID="btnOKUpd" runat="server" Width="70px"  Text="添加" CssClass="btn btn-outline-info btn-sm" Style="z-index: 103;
                        left: 608px; position: absolute; top: 0px" OnClick="btnOKUpd_Click"></asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="215px" Height="13px" Style="z-index: 104;
                        left: 384px; position: absolute; top: 8px" CssClass="text-warning"></asp:Label>
                </div>
            </td>
        </tr>
        <tr>
            <td valign="top" colspan="2">
                <uc1:wucViewInfo ID="wucViewInfo1" runat="server"></uc1:wucViewInfo>
            </td>
        </tr>
    </table>
  
</asp:Content>

