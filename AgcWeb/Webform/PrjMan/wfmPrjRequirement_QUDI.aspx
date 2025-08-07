<%@ Page Language="c#" CodeBehind="wfmPrjRequirement_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.wfmPrjRequirement_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucPrjRequirement" Src="wucPrjRequirement.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表PrjRequirement的查询、修改、删除、添加记录</title>

    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabLayout" style="z-index: 101; left: 8px; position: absolute; top: 48px"
            cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
            <tr>
                <td>
                    <table id="Table1" style="width: 672px; height: 120px" bordercolor="#003333" cellspacing="1"
                        cellpadding="1" width="672" border="4">
                        <tr>
                            <td>
                                <asp:Label ID="lblReqId_q" runat="server" Width="70px">需求编号</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtReqId_q" runat="server" Width="160px"></asp:TextBox></td>
                            <td>
                                <asp:Label ID="lblRequirement_q" runat="server" Width="70px">需求名称</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtRequirement_q" runat="server" Width="160px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="height: 23px"></td>
                            <td style="height: 23px"></td>
                            <td style="height: 23px">
                                <asp:Label ID="lblUpReqId_q" runat="server" Width="70px">父需求</asp:Label></td>
                            <td style="height: 23px">
                                <asp:DropDownList ID="ddlUpReqId_q" runat="server" Width="160px">
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblReqTypeId_q" runat="server" Width="70px">需求分类</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlReqTypeId_q" runat="server" Width="160px">
                                </asp:DropDownList></td>
                            <td>
                                <asp:Label ID="lblFuncModuleId_q" runat="server" Width="70px">
功能模块</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlFuncModuleId_q" runat="server" Width="160px">
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblIsFinished_q" runat="server" Width="70px">
是否已实现</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtIsFinished_q" runat="server" Width="160px"></asp:TextBox></td>
                            <td>
                                <asp:Button ID="btnQuery" runat="server"  
                                    Text="查询"></asp:Button></td>
                            <td></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabPrjRequirementDataGrid" style="z-index: 225; width: 672px"
                        bordercolor="#003333" cellspacing="1" cellpadding="1" width="672" border="4"
                        runat="server">
                        <tr>
                            <td style="width: 794px">
                                <div style="display: inline; width: 656px; position: relative; height: 32px">
                                    <asp:Label ID="lblPrjRequirementList" Style="z-index: 105; left: 8px; position: absolute; top: 4px"
                                        runat="server" CssClass="h6">项目需求列表</asp:Label>
                                    <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 106; left: 568px; position: absolute; top: 4px"
                                        runat="server"   Text="添加"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 794px">
                                <asp:DataGrid ID="dgPrjRequirement" runat="server" Width="656px"
                                    CellSpacing="1" GridLines="None" CellPadding="3" BackColor="White"
                                    BorderWidth="2px" BorderStyle="None" BorderColor="White" AutoGenerateColumns="False"
                                    PageSize="5" AllowPaging="True" AllowSorting="True">
                                    <FooterStyle ForeColor="Black" BackColor="#CCCCCC"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#008A8C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="Gainsboro"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="Black" BackColor="#EEEEEE"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#000084"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn Visible="False" HeaderText="选择">
                                            <HeaderStyle Width="30px"></HeaderStyle>
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="ReqId" SortExpression="ReqId" HeaderText="需求编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Requirement" SortExpression="Requirement" HeaderText="需求名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" SortExpression="PrjId" HeaderText="所属工程"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="ReqContent" SortExpression="ReqContent"
                                            HeaderText="需求详细内容"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UpReqId" SortExpression="UpReqId" HeaderText="父需求"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RequirementType" SortExpression="ReqTypeId" HeaderText="需求分类"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FuncModuleName" SortExpression="FuncModuleAgcId" HeaderText="功能模块"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsFinished" SortExpression="IsFinished" HeaderText="是否完成"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td style="width: 794px" bgcolor="silver">
                                <table id="tabPrjRequirementJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblPrjRequirementRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblPrjRequirementAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblPrjRequirementCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnPrjRequirementPrevPage" runat="server" Width="50px"
                                                        Text="上一页"></asp:Button><asp:Button ID="btnPrjRequirementNextPage"
                                                            runat="server" Width="50px" Text="下一页"></asp:Button>到第
                                                        <asp:TextBox ID="txtPrjRequirementJump2Page" runat="server" Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnPrjRequirementJumpPage" runat="server" Width="35px"
                                                            Text="确定"></asp:Button><asp:CompareValidator ID="PrjRequirementCompareValidator1"
                                                                runat="server" ForeColor="DarkOrange" ErrorMessage="错误！" ControlToValidate="txtPrjRequirementJump2Page"
                                                                Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditPrjRequirementRegion" style="width: 672px; height: 116px" bordercolor="#663300"
                        cellspacing="1" cellpadding="1" width="672" border="4" runat="server">
                        <tr>
                            <td style="height: 50px">
                                <div style="width: 656px; position: relative; height: 38px">
                                    <asp:Label ID="lblEditPrjRequirement" Style="z-index: 104; left: 8px; position: absolute; top: 4px"
                                        runat="server" CssClass="h6">项目需求编辑区域</asp:Label>
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 416px; position: absolute; top: 0px"
                                        runat="server"  
                                        Text="添加"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 160px; position: absolute; top: 8px"
                                        runat="server" Width="208px"
                                        CssClass="text-warning"></asp:Label>
                                    <asp:LinkButton ID="lbDispPrjRequirementList" Style="z-index: 107; left: 520px; position: absolute; top: 8px"
                                        runat="server" Width="120px">显示项目需求列表</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucPrjRequirement ID="wucPrjRequirement1" runat="server"></uc1:wucPrjRequirement>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:Label ID="Label1" Style="z-index: 102; left: 16px; position: absolute; top: 16px"
            runat="server" Width="224px"  CssClass="h5">项目功能管理->项目功能维护</asp:Label>
        <asp:Label ID="Label2" Style="z-index: 103; left: 336px; position: absolute; top: 16px"
            runat="server" CssClass="MemoStyle1">说明：主要维护项目的功能。用于项目的设计和编程。</asp:Label>

    </form>
</body>
</html>
