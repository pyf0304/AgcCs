<%@ Page Language="c#" CodeBehind="wfmPrjTabFld_Q.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrjTabFld_Q" EnableEventValidation="false" ResponseEncoding="utf-8" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>表PrjTabFld的查询修改记录</title>
    
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
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table style="z-index: 104; left: 4px; width: 100%; position: absolute; top: 2px">
        <tr>
            <td>
                <asp:Label ID="lblViewTile" runat="server" Font-Bold="True" CssClass="PageTitleT1">表字段信息查询</asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 95%">
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Width="32px" CssClass="text-secondary">模块</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncModuleId" runat="server" Width="224px" AutoPostBack="True"
                                OnSelectedIndexChanged="ddlFuncModuleId_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblFldNameq" runat="server" CssClass="text-secondary">字段名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFldNameq" runat="server" Width="120px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblPrjIdq" runat="server" CssClass="text-secondary" Width="35px">工程</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="144px" Enabled="False">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 3px">
                            <asp:Label ID="lblFldType_q0" runat="server" CssClass="text-secondary">数据类型</asp:Label>
                        </td>
                        <td style="width: 3px">
                            <asp:DropDownList ID="ddlDataTypeq" runat="server" Width="125px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblTabIdq" runat="server" CssClass="text-secondary">  表名</asp:Label>
                        </td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="ddlTabIdq" runat="server" Width="224px">
                                    </asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlFuncModuleId" EventName="SelectedIndexChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                        <td>
                            <asp:Label ID="lblFldTypeq" runat="server" CssClass="text-secondary">字段类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFldTypeq" runat="server" Width="125px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblPrimaryTypeIdq" runat="server" CssClass="text-secondary">主键类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPrimaryTypeIdq" runat="server" Width="144px">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 3px">
                            <asp:Button ID="btnQuery" runat="server"  Text="查询" OnClick="btnQuery_Click">
                            </asp:Button>
                        </td>
                        <td style="width: 3px">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table id="tabPrjTabFldDataGrid" style="width: 100%;" cellspacing="0" cellpadding="0"
                    width="100%" border="0" runat="server">
                    <tr>
                        <td style="height: 23px">
                            <div style="width: 860px; position: relative; height: 37px; left: 0px; top: 0px;">
                                <asp:Label ID="Label1" Style="z-index: 102; "
                                    runat="server" Font-Bold="True" CssClass="h6" Width="252px">表字段信息列表</asp:Label>
                                
                            <asp:Label ID="Label2" runat="server" CssClass="text-secondary">新字段名</asp:Label>
                            <asp:TextBox ID="txtFldName_New" runat="server" Width="120px"></asp:TextBox>
                                
                                  <asp:Label ID="lblFldType" runat="server" CssClass="text-secondary" Visible="False">数据类型</asp:Label>
                                <asp:DropDownList runat="server" TabIndex="102"  ID="ddlDataType" Style="z-index: 102; left: 280px; top: 0px" Visible="False"></asp:DropDownList>
                                
                                  <asp:Button ID="btnAddFldNameToPrjTab" Style="z-index: 101; " runat="server"  CssClass="btn btn-outline-info btn-sm" Width="100px" Text="添加字段到表" OnClick="btnAddFldNameToPrjTab_Click">
                                </asp:Button>
                                <asp:Button ID="btnExportExcel4Dg" Style="z-index: 101; " runat="server"  CssClass="btn btn-outline-info btn-sm"  Text="导出Excel" OnClick="btnExportExcel4Dg_Click">
                                </asp:Button>
                                
                            <asp:Label ID="lblMsg4AddRecord" runat="server" CssClass="text-secondary"></asp:Label>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 23px">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <table style="width: 100%">
                                        <tr>
                                            <td>
                                                <asp:DataGrid ID="dgPrjTabFld1" Style="z-index: 137; left: 100px; top: 431px" runat="server"
                                                    Width="100%" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                                    BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                                                    CellPadding="3" GridLines="Horizontal" CssClass="table table-striped table-bordered table-condensed" OnItemCreated="dgPrjTabFld_ItemCreated"
                                                    OnPageIndexChanged="dgPrjTabFld_PageIndexChanged" OnSortCommand="dgPrjTabFld_SortCommand" DataKeyField="mId" OnItemCommand="dgPrjTabFld_ItemCommand">
                                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                                    <Columns>
                                                        <asp:TemplateColumn HeaderText="选择">
                                                            <HeaderStyle Width="30px"></HeaderStyle>
                                                            <HeaderTemplate>
                                                                <asp:LinkButton ID="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap text-white" CommandName="lbSelAll">全选</asp:LinkButton>
                                                            </HeaderTemplate>
                                                            <ItemTemplate>
                                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateColumn>
                                                        <asp:BoundColumn Visible="False" DataField="mId" SortExpression="mId" HeaderText="mId">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn Visible="False" DataField="TabId" SortExpression="TabId" HeaderText="表ID">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="模块">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="表名"></asp:BoundColumn>
<asp:BoundColumn DataField="SqlDsTypeName" SortExpression="SqlDsTypeName" HeaderText="Sql数据源名"></asp:BoundColumn>
<asp:BoundColumn DataField="OrderNum4Refer" SortExpression="OrderNum4Refer" HeaderText="引用序号"></asp:BoundColumn>

                                                        
                                                        <asp:BoundColumn Visible="True" DataField="SequenceNumber" SortExpression="SequenceNumber"
                                                            HeaderText="序号"></asp:BoundColumn>
                                                        <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段"></asp:BoundColumn>
                                                        <asp:BoundColumn DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundColumn>
                                                        <asp:BoundColumn DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="类型">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="FldLength" SortExpression="FldLength" HeaderText="字段长度">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="IsTabNullable" SortExpression="IsTabNullable" HeaderText="可空?">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="FieldTypeName" HeaderText="字段类型"></asp:BoundColumn>                                                   
                                                        <asp:BoundColumn Visible="False" DataField="MinValue" SortExpression="MinValue" HeaderText="最小值">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn Visible="False" DataField="MaxValue" SortExpression="MaxValue" HeaderText="最大值">
                                                        </asp:BoundColumn>

                                                        <asp:BoundColumn DataField="FieldTypeName" SortExpression="FieldTypeName" HeaderText="字段类型">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="DefaultValue" SortExpression="DefaultValue" HeaderText="缺省值">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn Visible="False" DataField="IsParentObj" SortExpression="IsParentObj"
                                                            HeaderText="是否父对象"></asp:BoundColumn>
                                                        <asp:BoundColumn Visible="False" DataField="IsTabForeignKey" SortExpression="IsTabForeignKey"
                                                            HeaderText="是否表外键"></asp:BoundColumn>
                                                        <asp:BoundColumn Visible="False" DataField="ForeignTabName" SortExpression="ForeignTabName"
                                                            HeaderText="ForeignTabName"></asp:BoundColumn>
                                                        <asp:BoundColumn DataField="PrimaryTypeName" SortExpression="PrimaryTypeName" HeaderText="主键类型">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn Visible="False" DataField="MemoInTab" SortExpression="MemoInTab"
                                                            HeaderText="说明"></asp:BoundColumn>
                                                    </Columns>
                                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                                    </PagerStyle>
                                                </asp:DataGrid>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 100%" bgcolor="silver">
                                                <table id="tabPrjTabFldJumpPage" style="width: 100%; font-family: Verdana; height: 26px"
                                                    cellspacing="0" cellpadding="0" width="100%" border="1" runat="server" class="NameLabel">
                                                    <tr>
                                                        <td>
                                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                                                <asp:Label ID="lblPrjTabFldRecCount" runat="server" Width="36px" ForeColor="#000066">0</asp:Label>
                                                                <div style="display: inline; width: 16px; height: 13px">
                                                                </div>
                                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                                <asp:Label ID="lblPrjTabFldAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                                <div style="display: inline; width: 16px; height: 13px">
                                                                </div>
                                                                <font style="background-color: #c0c0c0">当前页:
                                                                    <asp:Label ID="lblPrjTabFldCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                                    <div style="display: inline; width: 16px; height: 13px">
                                                                    </div>
                                                                    <asp:Button ID="btnPrjTabFldPrevPage" runat="server" Width="50px" Text="上一页" OnClick="btnPrjTabFldPrevPage_Click">
                                                                    </asp:Button>
                                                                    <asp:Button ID="btnPrjTabFldNextPage" runat="server" Width="50px" Text="下一页" OnClick="btnPrjTabFldNextPage_Click">
                                                                    </asp:Button>
                                                                    到第
                                                                    <asp:TextBox ID="txtPrjTabFldJump2Page" runat="server" Width="35px"></asp:TextBox>页
                                                                    <asp:Button ID="btnPrjTabFldJumpPage" runat="server" Width="35px" Text="确定" OnClick="btnPrjTabFldJumpPage_Click">
                                                                    </asp:Button>
                                                                    <span class="text-secondary">页记录数:</span>
                                                                    <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                                                                        Width="61px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                                                                        <asp:ListItem>5</asp:ListItem>
                                                                        <asp:ListItem>10</asp:ListItem>
                                                                        <asp:ListItem>20</asp:ListItem>
                                                                        <asp:ListItem>30</asp:ListItem>
                                                                        <asp:ListItem>50</asp:ListItem>
                                                                        <asp:ListItem>100</asp:ListItem>
                                                                        <asp:ListItem>1000</asp:ListItem>
                                                                        <asp:ListItem></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                    <asp:CompareValidator ID="PrjTabFldCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                                        ErrorMessage="错误！" ControlToValidate="txtPrjTabFldJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnQuery" EventName="Click" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
