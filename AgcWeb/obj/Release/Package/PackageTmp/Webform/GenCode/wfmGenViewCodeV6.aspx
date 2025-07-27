<%@ Page Language="c#" CodeBehind="wfmGenViewCodeV6.aspx.cs" AutoEventWireup="True"
    ValidateRequest="false" Inherits="AGC.Webform.wfmGenViewCodeV6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>生成Web代码V6</title>
    
</head>
<body>
    <form id="Form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Label ID="Label3" Style="z-index: 100; left: 8px; position: absolute; top: 8px"
            runat="server" Width="240px" CssClass="h5">生成C#代码->WEB界面代码V5</asp:Label>
        <table id="Table1" style="z-index: 103; left: 8px; position: absolute; top: 66px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td valign="top">
                    <table id="tabMenu" style="z-index: 101; left: 8px;" cellspacing="1"
                        cellpadding="1" border="0">
                        <tr>
                            <td style="width: 137px">
                                <asp:Label ID="Label4" runat="server" CssClass="RegionTitleH3" Width="164px">生成一般控件、界面</asp:Label><br />
                                <asp:RadioButtonList ID="rblNetVersion" runat="server" Width="168px" RepeatDirection="Horizontal"
                                    CssClass="Radio_Defa">
                                    <asp:ListItem Value="Net2005">Net2005</asp:ListItem>
                                    <asp:ListItem Value="Net2010" Selected="True">Net2010</asp:ListItem>
                                </asp:RadioButtonList></td>
                        </tr>
                        <tr>
                            <td style="width: 137px">
                                <asp:Button ID="btnCtlViewCode" runat="server"  Width="173px" Text="表控件View代码"
                                    OnClick="btnCtlViewCode_Click" ToolTip="编辑区控件的View代码(HTML)"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 137px">
                                <asp:Button ID="btnCtlControlCode" runat="server"  Width="173px" Text="表控件Control代码"
                                    OnClick="btnCtlControlCode_Click" ToolTip="编辑区控件的后台代码(C#)"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 137px">
                                <asp:Button ID="btnGenViewCode" runat="server" Width="173px"  Text="界面View代码"
                                    OnClick="btnGenViewCode_Click" ToolTip="界面的View代码(HTML代码)"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 137px">
                                <asp:Button ID="btnGenControlCode" runat="server" Width="173px"  Text="界面Control代码"
                                    OnClick="btnGenControlCode_Click" ToolTip="界面的后台代码(C#代码)"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnGenGeneLogicCode" runat="server" Width="173px"  Text="数据逻辑层"
                                    OnClick="btnGenGeneLogicCode_Click" ToolTip="专门用于SQL的数据逻辑层"></asp:Button>
                                <br />
                                <asp:Button ID="btnGenGeneExLogicCode" runat="server"  Width="173px"
                                    Text="数据逻辑层Ex" OnClick="btnGenGeneExLogicCode_Click" ToolTip="专门用于SQL的数据逻辑层扩展类"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 137px">
                                <asp:Button ID="btnGenGeneLogicCode_Oracle" runat="server"  Width="173px"
                                    Text="数据逻辑层_Ora" OnClick="btnGenGeneLogicCode_Oracle_Click" ToolTip="专门用于Oracle的数据逻辑层"></asp:Button><br />
                                <asp:Button ID="btnGenGeneLogicCodeEx_Oracle" runat="server"  Width="173px"
                                    Text="逻辑层Ex_Ora" OnClick="btnGenGeneLogicCodeEx_Oracle_Click"></asp:Button></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label2" runat="server" CssClass="RegionTitleH3" Width="124px">生成查询显示控件</asp:Label>
                                </td>
                        </tr>
                        <tr>
                            <td style="width: 137px">
                                <asp:Button ID="btnCtlViewCode_Disp" runat="server"  Width="173px" Text="专用于显示的表控件"
                                    OnClick="btnCtlViewCode_Disp_Click"></asp:Button></td>
                        </tr>
                        <tr>
                            <td style="height: 28px; width: 137px;">
                                <asp:Button ID="btnCtlViewCtlCode_Disp" runat="server"  Width="173px"
                                    Text="专用于显示的表控件Ctl代码" OnClick="btnCtlViewCtlCode_Disp_Click"></asp:Button></td>
                        </tr>
                        <tr>
                            <td style="height: 28px; width: 137px;">
                                <asp:Button ID="btnCtlViewCode4Query" runat="server"  Width="173px"
                                    Text="生成表查询控件View代码" OnClick="btnCtlViewCode4Query_Click"></asp:Button></td>
                        </tr>
                        <tr>
                            <td style="width: 137px">
                                <asp:Button ID="btnCtlControlCode4Query" runat="server"  Width="173px"
                                    Text="生成表查询控件Control代码" OnClick="btnCtlControlCode4Query_Click"></asp:Button></td>
                        </tr>
                    </table>
                </td>
                <td valign="top">
                    <table id="tabCode" style="width: 776px; height: 44px" cellspacing="1" cellpadding="1"
                        width="776" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 760px; position: relative; height: 32px">
                                    <asp:Label ID="lblCaption4GenCode" runat="server" Width="120px"  Font-Names="宋体"
                                        Font-Size="Smaller" Style="z-index: 101; left: 8px; position: absolute; top: 8px">生成的逻辑层代码：</asp:Label>
                                    <asp:LinkButton ID="lbDispTabList" runat="server" Style="z-index: 102; left: 664px;
                                        position: absolute; top: 8px" OnClick="lbDispTabList_Click">显示界面列表</asp:LinkButton>
                                    <asp:Label ID="Label1" Style="z-index: 103; left: 152px; position: absolute; top: 8px"
                                        runat="server"   CssClass="text-secondary">生成文件名：</asp:Label>
                                    <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 248px; position: absolute;
                                        top: 8px" runat="server"  Width="336px"></asp:TextBox>
                                    <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 600px; position: absolute;
                                        top: 8px" runat="server"  Width="56px" OnClick="lbDownLoadFile_Click">下载文件</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                  <asp:Literal ID="litCode" runat="server"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblMsg2" Style="z-index: 101; left: 272px; position: absolute; top: 8px"
            runat="server" Height="13px" Width="448px" ForeColor="Red"></asp:Label>
        <table style="width: 753px; z-index: 104; left: 8px; position: absolute; top: 36px;">
            <tr>
                <td style="width: 76px;">
                    <asp:Label ID="Label10" runat="server" BorderColor="#004040" CssClass="text-secondary"
                        >界面名称：</asp:Label></td>
                <td >
                    <asp:Label ID="lblViewName" runat="server" BorderColor="#004040" CssClass="ValueLabelH1"
                        >添加相关界面区域</asp:Label></td>
                <td style="width: 176px; height: 15px">
                                <asp:Button ID="btnPreView" runat="server"  Width="173px" Text="预览各区域"
                                    OnClick="btnPreView_Click" ToolTip="显示界面中各区域的界面效果。"></asp:Button></td>
            </tr>
        </table>
    </form>
</body>
</html>
