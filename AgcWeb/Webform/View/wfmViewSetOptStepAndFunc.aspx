<%@ Register TagPrefix="uc1" TagName="wucViewInfo" Src="wucViewInfo.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmViewSetOptStepAndFunc.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewSetOptStepAndFunc"  EnableEventValidation="false" ResponseEncoding="utf-8" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>界面流程函数维护</title>
    
    <script language="javascript" type="text/javascript">
		<!--
    function radioClick() {
        if (document.Form1.RadioName != null) {
            for (i = 0; i < document.Form1.RadioName.length; i++) {
                if (document.Form1.RadioName[i].checked == true) {
                    document.Form1.rd.value = document.Form1.RadioName[i].value;
                    //document.getElementById("TextBox1").value = document.Form1.rd.value;
                }
            }
        }
    }
    //-->
    </script>
      <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
            <asp:Label ID="Label3" Style="z-index: 107; left: 8px; position: absolute; top: 8px"
                runat="server" Width="224px" CssClass="h5">项目界面管理->流程及函数</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 103; left: 256px; position: absolute; top: 8px"
                runat="server" ForeColor="#004040" Width="42px" 
                 Font-Bold="True" CssClass="MemoStyleH5">说明：</asp:Label>
            <asp:Label ID="Label4" Style="z-index: 101; left: 312px; position: absolute; top: 8px"
                runat="server" ForeColor="#004040" Width="464px" Height="32px" CssClass="MemoStyle1" 
                >主要用户设计在项目中的界面。设置界面各种要素，包括：界面类型、功能、流程、相关表，以及主键等信息。</asp:Label>
            <table id="tabHidden" style="z-index: 106; left: 840px; position: absolute; top: 8px"
                cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td style="width: 61px">
                        <asp:Label ID="lblUserIdq" runat="server"  
                            >用户ID</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUserIdq" runat="server" Width="49px"  
                            ></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblPrjIdq" runat="server"  
                            >工程ID</asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="112px" 
                            >
                        </asp:DropDownList></td>
                </tr>
            </table>
            &nbsp;
            <input id="rd" style="z-index: 109; left: 896px; width: 24px; position: absolute;
                top: 48px; height: 22px" type="hidden" size="1" name="rd" runat="server">
            <input style="display: none; z-index: 110; left: 8px; position: absolute; top: 8px"
                type="radio" checked name="RadioName"/>
            <table id="Table1" style="z-index: 112; left: 8px; width: 864px; position: absolute;
                top: 48px; height: 406px" cellspacing="0" cellpadding="0" width="864" border="0">
                <tr>
                    <td valign="top" style="height: 412px">
                        <table id="tabQuery1" bordercolor="#666666" cellspacing="1" cellpadding="1" width="848"
                            border="4" runat="server" style="width: 848px; height: 411px">
                            <tr>
                                <td colspan="2">
                                    <table id="tabQuery" style="width: 728px; height: 48px" bordercolor="#666666" cellspacing="1"
                                        cellpadding="1" width="728" border="4">
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblViewNameq" runat="server" Width="56px" CssClass="text-secondary" 
                                                    >界面名称</asp:Label></td>
                                            <td>
                                                <asp:TextBox ID="txtViewNameq" runat="server" Width="112px" 
                                                    ></asp:TextBox></td>
                                            <td style="width: 62px">
                                                <asp:Label ID="lblViewTypeCodeq" runat="server" Width="72px" CssClass="text-secondary" 
                                                    >界面类型码</asp:Label></td>
                                            <td>
                                                <asp:DropDownList ID="ddlViewTypeCodeq" runat="server" Width="113px" 
                                                   >
                                                </asp:DropDownList></td>
                                            <td>
                                                <asp:Label ID="Label1" runat="server"  
                                                    Width="56px" CssClass="text-secondary">功能模块</asp:Label></td>
                                            <td>
                                                <asp:DropDownList ID="ddlFuncModuleIdq" runat="server"  Width="104px">
                                                </asp:DropDownList></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblMainTabNameq" runat="server" Width="56px" CssClass="text-secondary" 
                                                    >界面表名</asp:Label></td>
                                            <td>
                                                <asp:TextBox ID="txtMainTabNameq" runat="server" Width="113px" 
                                                    ></asp:TextBox></td>
                                            <td style="width: 62px">
                                                <asp:Label ID="lblDetailTabNameq" runat="server" Width="56px" CssClass="text-secondary" 
                                                    >明细表名</asp:Label></td>
                                            <td>
                                                <asp:TextBox ID="txtDetailTabNameq" runat="server" Width="104px" 
                                                    ></asp:TextBox></td>
                                            <td>
                                                <asp:Button ID="btnQuery" runat="server" 
                                                      Text="查询" OnClick="btnQuery_Click"></asp:Button></td>
                                            <td>
                                                <asp:Label ID="lblMsg2" runat="server"  Height="13px"
                                                    Width="160px" ForeColor="Red" CssClass="text-warning"></asp:Label></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <div style="display: inline; width: 840px; position: relative; height: 24px">
                                        <asp:Button ID="btnEditViewFunction" Style="z-index: 102; left: 584px; position: absolute;
                                            top: 0px" runat="server"  Width="88px" Text="编辑界面函数" OnClick="btnEditViewField_Click"></asp:Button>
                                        <asp:Button ID="btnBtnOptStep" Style="z-index: 103; left: 472px; position: absolute;
                                            top: 0px" runat="server"  Width="88px" Text="按钮操作流程" OnClick="btnBtnOptStep_Click"></asp:Button>
                                        <asp:Button ID="btnViewOptStep" Style="z-index: 105; left: 360px; position: absolute;
                                            top: 0px" runat="server"  Width="88px" Text="界面操作流程" OnClick="btnViewOptStep_Click"></asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:DataGrid ID="dgViewInfo" runat="server" Width="840px" Height="214px" Font-Names="宋体"
                                        Font-Size="Smaller" GridLines="Vertical" CellPadding="0" BackColor="White" BorderWidth="1px"
                                        BorderStyle="Ridge" BorderColor="White" AutoGenerateColumns="False" AllowPaging="True"
                                        AllowSorting="True" OnItemCreated="dgViewInfo_ItemCreated" OnItemDataBound="dgViewInfo_ItemDataBound" OnPageIndexChanged="dgViewInfo_PageIndexChanged">
                                        <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                                        <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                                        <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                                        <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                                        <Columns>
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <input onclick="radioClick()" type="radio" value='<%# DataBinder.Eval(Container.DataItem, "ViewId")%>'
                                                        name="RadioName" />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn Visible="False" DataField="ViewId" HeaderText="界面ID"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewCnName" SortExpression="ViewCnName" HeaderText="中文名称">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewTypeName" SortExpression="ViewTypeName" HeaderText="界面类型码">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="DataBaseName" SortExpression="DataBaseName"
                                                HeaderText="数据库名"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="MainTabName" SortExpression="MainTabName" HeaderText="界面主表">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="DetailTabName" SortExpression="DetailTabName" HeaderText="明细表名">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="KeyForMainTab" HeaderText="主表关键字"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="KeyForDetailTab" HeaderText="明细表关键字"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="IsNeedSort" SortExpression="IsNeedSort"
                                                HeaderText="排序"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="IsNeedTransCode" SortExpression="IsNeedTransCode"
                                                HeaderText="转换代码"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="UserId" HeaderText="用户ID"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="PrjName" HeaderText="工程ID"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="ViewFunction" HeaderText="界面功能"></asp:BoundColumn>
                                        </Columns>
                                        <PagerStyle NextPageText="&amp;lt;下一页&amp;gt;" PrevPageText="&amp;lt;上一页&amp;gt;"
                                            HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6"></PagerStyle>
                                    </asp:DataGrid></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                                        Font-Size="Smaller">查询结果记录数：</asp:Label></td>
                                <td rowspan="1">
                                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                                        Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                    <td style="height: 412px">
                    </td>
                    <td style="height: 412px">
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
