<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Demo1.aspx.cs" Inherits="Webform_Demo_Demo1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlObjIdq" runat="server" Width="176px">
                    </asp:DropDownList>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="txtViewName" EventName="TextChanged" />                
                    <asp:AsyncPostBackTrigger ControlID="ddlFuncModuleIdq" EventName="SelectedIndexChanged" />
                    <asp:AsyncPostBackTrigger ControlID="btnQuery" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" /><br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="CheckBox1" EventName="CheckedChanged" />
                </Triggers>
            </asp:UpdatePanel>
            
        </div>
    </form>
</body>
</html>
