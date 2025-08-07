<%@ Register TagPrefix="uc1" TagName="wucPrjTab" Src="..\Table\wucPrjTab.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmPrjTab_Add.aspx.cs" 
    Inherits="AGC.Webform.wfmPrjTab_Add" ValidateRequest="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>工程表维护</title>
    
  
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID ="ScriptManager1" runat="server" EnablePartialRendering="true">
        </asp:ScriptManager>
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px"
            cellspacing="0" cellpadding="0" width="300" border="0" runat="server">
            <tr>
                <td style="height: 18px; width: 873px;">
                    <div style="position: relative; width: 481px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >表字段管理-&gt;项目表添加</asp:Label>
                     </div>
                </td>
            </tr>
            
            
           
          
            <tr style="font-size: 12pt; font-family: Times New Roman">
                <td style="width: 873px">
                    <table id="tabEditPrjTabRegion" style="z-index: 120; width: 750px" cellspacing="1"
                        cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 730px; position: relative; height: 32px">
                                    <asp:Label ID="lblEditPrjTab" Style="z-index: 104; left: 0px; position: relative;
                                        top: 4px" runat="server" CssClass="h6">工程表编辑区域</asp:Label>
                                    <asp:Label ID="lblMsgEdit" Style="z-index: 105; left: 54px; position: relative;
                                        top: 8px" runat="server" Width="208px" CssClass="text-warning"></asp:Label>
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 68px; position: relative; top: 4px"
                                        runat="server"  Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm">
                                    </asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucPrjTab ID="wucPrjTab1" runat="server"></uc1:wucPrjTab>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
           
        </table>
    </form>
</body>
</html>
